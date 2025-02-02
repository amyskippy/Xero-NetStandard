/* 
 * Bank Feeds API
 *
 * This specifing endpoints Xero Bank feeds API
 *
 * The version of the OpenAPI document: 2.6.1
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Model.Bankfeeds;
using AutoBogus;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Xero.NetStandard.OAuth2.Test.Api.Bankfeeds
{
    /// <summary>
    ///  Class for testing BankFeedsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BankFeedsApiTests : IAsyncLifetime
    {
        private const string accessToken = "XeroNetStandardTestAccessToken";
        private const string xeroTenantId = "XeroNetStandardTestTenantId";
        private BankFeedsApi instance;
        private readonly ITestOutputHelper output;

        public BankFeedsApiTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        // Methods are async but may not require it in specific cases
        #pragma warning disable CS1998 // This async method lacks 'await' operators
        public async Task InitializeAsync()
        {
            var directory = Directory.GetCurrentDirectory();
            var configuration = TestHelper.GetApplicationConfiguration(directory);
            var config = new Xero.NetStandard.OAuth2.Client.Configuration();
            config.BasePath = configuration.BankfeedsBaseUrl;
            instance = new BankFeedsApi(config);
        }

        public async Task DisposeAsync()
        {
            // Cleanup when everything is done.
        }
        #pragma warning restore CS1998 // This async method lacks 'await' operators

        /// <summary>
        /// Test an instance of BankFeedsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BankFeedsApi
            //Assert.IsType(typeof(BankFeedsApi), instance, "instance is a BankFeedsApi");
        }

        
        /// <summary>
        /// Test CreateFeedConnections
        /// </summary>
        [Fact]
        public async Task CreateFeedConnectionsTest()
        {
            FeedConnections feedConnections = new FeedConnections();
            var response = await instance.CreateFeedConnectionsAsync(accessToken, xeroTenantId, feedConnections);
            Assert.IsType<FeedConnections>(response);
        }
        
        /// <summary>
        /// Test CreateStatements
        /// </summary>
        [Fact]
        public async Task CreateStatementsTest()
        {
            Statements statements = new Statements();
            string idempotencyKey = AutoFaker.Generate<string>();
            var response = await instance.CreateStatementsAsync(accessToken, xeroTenantId, idempotencyKey, statements);
            Assert.IsType<Statements>(response);
        }
        
        /// <summary>
        /// Test DeleteFeedConnections
        /// </summary>
        [Fact]
        public async Task DeleteFeedConnectionsTest()
        {
            FeedConnections feedConnections = new FeedConnections();
            var response = await instance.DeleteFeedConnectionsAsync(accessToken, xeroTenantId, feedConnections);
            Assert.IsType<FeedConnections>(response);
        }
        
        /// <summary>
        /// Test GetFeedConnection
        /// </summary>
        [Fact]
        public async Task GetFeedConnectionTest()
        {
            Guid id = Guid.NewGuid();
            var response = await instance.GetFeedConnectionAsync(accessToken, xeroTenantId, id);
            Assert.IsType<FeedConnection>(response);
        }
        
        /// <summary>
        /// Test GetFeedConnections
        /// </summary>
        [Fact]
        public async Task GetFeedConnectionsTest()
        {
            int? page = AutoFaker.Generate<int>();
            int? pageSize = AutoFaker.Generate<int>();
            var response = await instance.GetFeedConnectionsAsync(accessToken, xeroTenantId, page, pageSize);
            Assert.IsType<FeedConnections>(response);
        }
        
        /// <summary>
        /// Test GetStatement
        /// </summary>
        [Fact]
        public async Task GetStatementTest()
        {
            Guid statementId = Guid.NewGuid();
            var response = await instance.GetStatementAsync(accessToken, xeroTenantId, statementId);
            Assert.IsType<Statement>(response);
        }
        
        /// <summary>
        /// Test GetStatements
        /// </summary>
        [Fact]
        public async Task GetStatementsTest()
        {
            int? page = AutoFaker.Generate<int>();
            int? pageSize = AutoFaker.Generate<int>();
            string xeroApplicationId = AutoFaker.Generate<string>();
            string xeroUserId = AutoFaker.Generate<string>();
            var response = await instance.GetStatementsAsync(accessToken, xeroTenantId, page, pageSize, xeroApplicationId, xeroUserId);
            Assert.IsType<Statements>(response);
        }
        
    }

}
