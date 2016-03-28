﻿using System;
using Nest;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZakLyd.Web.InterfaceEntities;
using ZakLyd.Infrastructure.ElasticRepository.Types;

namespace ZakLyd.Infrastructure.ElasticRepository
{
    public class ElasticRepository : IDisposable
    {
        private readonly IEnumerable<Uri> _elasticNodes;
        public ConnectionStatus ConnectionStatus { get; set; }
        public ElasticClient Client { get; set; }

        public ElasticRepository(IEnumerable<string> elasticNodeList)
        {
            ConnectionStatus = new ConnectionStatus();
            _elasticNodes = elasticNodeList.Select(strNode => new Uri(strNode)).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ElasticRepository Connect()
        {
            if (_elasticNodes.Any())
            {
                try
                {
                    var connectionPool = new Elasticsearch.Net.StaticConnectionPool(_elasticNodes.ToArray());
                    var settings = new ConnectionSettings(connectionPool);
                    Client = new ElasticClient(settings);
                    ConnectionStatus.IsSuccess = true;
                    ConnectionStatus.Message = "OK";
                }
                catch (Exception ex)
                {
                    ConnectionStatus.IsSuccess = false;
                    ConnectionStatus.Message =
                        $"[ElasticRepository::Connect] Error when connectiong to Elastic pool. Message: {ex.Message}";
                }

            }
            else
            {
                ConnectionStatus.IsSuccess = false;
                ConnectionStatus.Message =
                    "[ElasticRepository::Connect] Error, Elastic node collection is null or empty";
            }

            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="docId"></param>
        /// <param name="index"></param>
        /// <param name="docType"></param>
        /// <returns></returns>
        public IGetResponse<T> GetDocumentById<T>(int docId, string index, string docType) where T : InterfaceEntity
        {
            var request = new GetRequest("myindex", "mytype", docId);

            return Client.Get<T>(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="docId"></param>
        /// <param name="index"></param>
        /// <param name="docType"></param>
        /// <returns></returns>
        public Task<IGetResponse<T>> GetDocumentByIdAsync<T>(int docId, string index, string docType) where T : InterfaceEntity
        {
            var request = new GetRequest("myindex", "mytype", docId);

            return Client.GetAsync<T>(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public SearchResult<T> Query<T>(SearchRequest request) where T : InterfaceEntity
        {
            SearchResult<T> searchResult = new SearchResult<T>();
            try
            {
                searchResult.Result = Client.Search<T>(request);
                searchResult.IsSuccess = true;
                searchResult.Message = "OK";

            }
            catch (Exception ex)
            {
                searchResult.Result = null;
                searchResult.IsSuccess = false;
                searchResult.Message = $"[ElasticRepository::Query] Error when on query. Message: {ex.Message}";
            }

            return searchResult;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SearchResult<T>> QueryAsync<T>(SearchRequest request) where T : InterfaceEntity
        {
            var searchResult = new SearchResult<T>();
            try
            {
                searchResult.Result = await Client.SearchAsync<T>(request);
                searchResult.IsSuccess = true;
                searchResult.Message = "OK";

            }
            catch (Exception ex)
            {
                searchResult.Result = null;
                searchResult.IsSuccess = false;
                searchResult.Message = $"[ElasticRepository::Query] Error when on query. Message: {ex.Message}";
            }

            return searchResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Client.ConnectionSettings.Connection.Dispose();
        }

    }
}
