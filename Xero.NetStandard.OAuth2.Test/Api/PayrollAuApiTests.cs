/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using RestSharp;
using Xunit;

using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Model.PayrollAu;
using Xunit.Abstractions;
using AutoBogus;

namespace Xero.NetStandard.OAuth2.Test.Api.PayrollAu
{
    /// <summary>
    ///  Class for testing PayrollAuApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PayrollAuApiTests : IAsyncLifetime
    {
        private const string accessToken = "XeroNetStandardTestAccessToken";
        private const string xeroTenantId = "XeroNetStandardTestTenantId";
        private PayrollAuApi instance;
        private readonly ITestOutputHelper output;

        public PayrollAuApiTests()
        {
            instance = new PayrollAuApi();
        }

        // Methods are async but may not require it in specific cases
        #pragma warning disable CS1998 // This async method lacks 'await' operators
        public async Task InitializeAsync()
        {
            var directory = Directory.GetCurrentDirectory();
            var configuration = TestHelper.GetApplicationConfiguration(directory);
            var config = new Xero.NetStandard.OAuth2.Client.Configuration();
            config.BasePath = configuration.PayrollAuBaseUrl;
            instance = new PayrollAuApi(config);
        }

        public async Task DisposeAsync()
        {
            // Cleanup when everything is done.
        }
        #pragma warning restore CS1998 // This async method lacks 'await' operators

        /// <summary>
        /// Test an instance of PayrollAuApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<PayrollAuApi>(instance);
        }

        
        /// <summary>
        /// Test CreateEmployee
        /// </summary>
        [Fact]
        public async Task CreateEmployeeTest()
        {
            List<Employee> employee =
                new List<Employee> { new Employee() };
            var response = await instance.CreateEmployeeAsync(accessToken, xeroTenantId, employee);
            Assert.IsType<Employees>(response);
        }
        
        /// <summary>
        /// Test CreateLeaveApplication
        /// </summary>
        [Fact]
        public async Task CreateLeaveApplicationTest()
        {
            List<LeaveApplication> leaveApplication =
                new List<LeaveApplication> { new LeaveApplication() };
            var response = await instance.CreateLeaveApplicationAsync(accessToken, xeroTenantId, leaveApplication);
            Assert.IsType<LeaveApplications>(response);
        }
        
        /// <summary>
        /// Test CreatePayItem
        /// </summary>
        [Fact]
        public async Task CreatePayItemTest()
        {
            PayItem payItem = new PayItem();
            var response = await instance.CreatePayItemAsync(accessToken, xeroTenantId, payItem);
            Assert.IsType<PayItems>(response);
        }
        
        /// <summary>
        /// Test CreatePayRun
        /// </summary>
        [Fact]
        public async Task CreatePayRunTest()
        {
            List<PayRun> payRun = new List<PayRun> { new PayRun() };
            var response = await instance.CreatePayRunAsync(accessToken, xeroTenantId, payRun);
            Assert.IsType<PayRuns>(response);
        }
        
        /// <summary>
        /// Test CreatePayrollCalendar
        /// </summary>
        [Fact]
        public async Task CreatePayrollCalendarTest()
        {
            List<PayrollCalendar> payrollCalendar = new List<PayrollCalendar> { new PayrollCalendar() };
            var response = await instance.CreatePayrollCalendarAsync(accessToken, xeroTenantId, payrollCalendar);
            Assert.IsType<PayrollCalendars>(response);
        }
        
        /// <summary>
        /// Test CreateSuperfund
        /// </summary>
        [Fact]
        public async Task CreateSuperfundTest()
        {
            List<SuperFund> superFund = new List<SuperFund> { new SuperFund() };
            var response = await instance.CreateSuperfundAsync(accessToken, xeroTenantId, superFund);
            Assert.IsType<SuperFunds>(response);
        }
        
        /// <summary>
        /// Test CreateTimesheet
        /// </summary>
        [Fact]
        public async Task CreateTimesheetTest()
        {
            List<Timesheet> timesheet = new List<Timesheet> { new Timesheet() };
            var response = await instance.CreateTimesheetAsync(accessToken, xeroTenantId, timesheet);
            Assert.IsType<Timesheets>(response);
        }
        
        /// <summary>
        /// Test GetEmployee
        /// </summary>
        [Fact]
        public async Task GetEmployeeTest()
        {
            Guid employeeId = AutoFaker.Generate<Guid>();
            var response = await instance.GetEmployeeAsync(accessToken, xeroTenantId, employeeId);
            Assert.IsType<Employees>(response);
        }
        
        /// <summary>
        /// Test GetEmployees
        /// </summary>
        [Fact]
        public async Task GetEmployeesTest()
        {
            string ifModifiedSince = "2020-12-25"; // SDK validates date format
            string where = AutoFaker.Generate<string>();
            string order = AutoFaker.Generate<string>();
            int? page = AutoFaker.Generate<int>();
            var response = await instance.GetEmployeesAsync(accessToken, xeroTenantId, ifModifiedSince, where, order, page);
            Assert.IsType<Employees>(response);
        }
        
        /// <summary>
        /// Test GetLeaveApplication
        /// </summary>
        [Fact]
        public async Task GetLeaveApplicationTest()
        {
            Guid leaveApplicationId = AutoFaker.Generate<Guid>();
            var response = await instance.GetLeaveApplicationAsync(accessToken, xeroTenantId, leaveApplicationId);
            Assert.IsType<LeaveApplications>(response);
        }
        
        /// <summary>
        /// Test GetLeaveApplications
        /// </summary>
        [Fact]
        public async Task GetLeaveApplicationsTest()
        {
            string ifModifiedSince = "2020-12-25"; // SDK validates date format
            string where = AutoFaker.Generate<string>();
            string order = AutoFaker.Generate<string>();
            int? page = AutoFaker.Generate<int>();
            var response = await instance.GetLeaveApplicationsAsync(accessToken, xeroTenantId, ifModifiedSince, where, order, page);
            Assert.IsType<LeaveApplications>(response);
        }
        
        /// <summary>
        /// Test GetPayItems
        /// </summary>
        [Fact]
        public async Task GetPayItemsTest()
        {
            string ifModifiedSince = "2020-12-25"; // SDK validates date format
            string where = AutoFaker.Generate<string>();
            string order = AutoFaker.Generate<string>();
            int? page = AutoFaker.Generate<int>();
            var response = await instance.GetPayItemsAsync(accessToken, xeroTenantId, ifModifiedSince, where, order, page);
            Assert.IsType<PayItems>(response);
        }
        
        /// <summary>
        /// Test GetPayRun
        /// </summary>
        [Fact]
        public async Task GetPayRunTest()
        {
            Guid payRunID = AutoFaker.Generate<Guid>();
            var response = await instance.GetPayRunAsync(accessToken, xeroTenantId, payRunID);
            Assert.IsType<PayRuns>(response);
        }
        
        /// <summary>
        /// Test GetPayRuns
        /// </summary>
        [Fact]
        public async Task GetPayRunsTest()
        {
            string ifModifiedSince = "2020-12-25"; // SDK validates date format
            string where = AutoFaker.Generate<string>();
            string order = AutoFaker.Generate<string>();
            int? page = AutoFaker.Generate<int>();
            var response = await instance.GetPayRunsAsync(accessToken, xeroTenantId, ifModifiedSince, where, order, page);
            Assert.IsType<PayRuns>(response);
        }
        
        /// <summary>
        /// Test GetPayrollCalendar
        /// </summary>
        [Fact]
        public async Task GetPayrollCalendarTest()
        {
            Guid payrollCalendarID = AutoFaker.Generate<Guid>();
            var response = await instance.GetPayrollCalendarAsync(accessToken, xeroTenantId, payrollCalendarID);
            Assert.IsType<PayrollCalendars>(response);
        }
        
        /// <summary>
        /// Test GetPayrollCalendars
        /// </summary>
        [Fact]
        public async Task GetPayrollCalendarsTest()
        {
            string ifModifiedSince = "2020-12-25"; // SDK validates date format
            string where = AutoFaker.Generate<string>();
            string order = AutoFaker.Generate<string>();
            int? page = AutoFaker.Generate<int>();
            var response = await instance.GetPayrollCalendarsAsync(accessToken, xeroTenantId, ifModifiedSince, where, order, page);
            Assert.IsType<PayrollCalendars>(response);
        }
        
        /// <summary>
        /// Test GetPayslip
        /// </summary>
        [Fact]
        public async Task GetPayslipTest()
        {
            Guid payslipID = AutoFaker.Generate<Guid>();
            var response = await instance.GetPayslipAsync(accessToken, xeroTenantId, payslipID);
            Assert.IsType<PayslipObject>(response);
        }
        
        /// <summary>
        /// Test GetSettings
        /// </summary>
        [Fact]
        public async Task GetSettingsTest()
        {
            var response = await instance.GetSettingsAsync(accessToken, xeroTenantId);
            Assert.IsType<SettingsObject>(response);
        }
        
        /// <summary>
        /// Test GetSuperfund
        /// </summary>
        [Fact]
        public async Task GetSuperfundTest()
        {
            Guid superFundID = AutoFaker.Generate<Guid>();
            var response = await instance.GetSuperfundAsync(accessToken, xeroTenantId, superFundID);
            Assert.IsType<SuperFunds>(response);
        }
        
        /// <summary>
        /// Test GetSuperfundProducts
        /// </summary>
        [Fact]
        public async Task GetSuperfundProductsTest()
        {
            string ABN = AutoFaker.Generate<string>();
            string USI = AutoFaker.Generate<string>();
            var response = await instance.GetSuperfundProductsAsync(accessToken, xeroTenantId, ABN, USI);
            Assert.IsType<SuperFundProducts>(response);
        }
        
        /// <summary>
        /// Test GetSuperfunds
        /// </summary>
        [Fact]
        public async Task GetSuperfundsTest()
        {
            string ifModifiedSince = "2020-12-25"; // SDK validates date format
            string where = AutoFaker.Generate<string>();
            string order = AutoFaker.Generate<string>();
            int? page = AutoFaker.Generate<int>();
            var response = await instance.GetSuperfundsAsync(accessToken, xeroTenantId, ifModifiedSince, where, order, page);
            Assert.IsType<SuperFunds>(response);
        }
        
        /// <summary>
        /// Test GetTimesheet
        /// </summary>
        [Fact]
        public async Task GetTimesheetTest()
        {
            Guid timesheetID = AutoFaker.Generate<Guid>();
            var response = await instance.GetTimesheetAsync(accessToken, xeroTenantId, timesheetID);
            Assert.IsType<TimesheetObject>(response);
        }
        
        /// <summary>
        /// Test GetTimesheets
        /// </summary>
        [Fact]
        public async Task GetTimesheetsTest()
        {
            string ifModifiedSince = "2020-12-25"; // SDK validates date format
            string where = AutoFaker.Generate<string>();
            string order = AutoFaker.Generate<string>();
            int? page = AutoFaker.Generate<int>();
            var response = await instance.GetTimesheetsAsync(accessToken, xeroTenantId, ifModifiedSince, where, order, page);
            Assert.IsType<Timesheets>(response);
        }
        
        /// <summary>
        /// Test UpdateEmployee
        /// </summary>
        [Fact]
        public async Task UpdateEmployeeTest()
        {
            Guid employeeId = AutoFaker.Generate<Guid>();
            List<Employee> employee = new List<Employee> { new Employee() };
            var response = await instance.UpdateEmployeeAsync(accessToken, xeroTenantId, employeeId, employee);
            Assert.IsType<Employees>(response);
        }
        
        /// <summary>
        /// Test UpdateLeaveApplication
        /// </summary>
        [Fact]
        public async Task UpdateLeaveApplicationTest()
        {
            Guid leaveApplicationId = AutoFaker.Generate<Guid>();
            List<LeaveApplication> leaveApplication = new List<LeaveApplication> { new LeaveApplication() };
            var response = await instance.UpdateLeaveApplicationAsync(accessToken, xeroTenantId, leaveApplicationId, leaveApplication);
            Assert.IsType<LeaveApplications>(response);
        }
        
        /// <summary>
        /// Test UpdatePayRun
        /// </summary>
        [Fact]
        public async Task UpdatePayRunTest()
        {
            Guid payRunID = AutoFaker.Generate<Guid>();
            List<PayRun> payRun = new List<PayRun> { new PayRun() };
            var response = await instance.UpdatePayRunAsync(accessToken, xeroTenantId, payRunID, payRun);
            Assert.IsType<PayRuns>(response);
        }
        
        /// <summary>
        /// Test UpdatePayslip
        /// </summary>
        [Fact]
        public async Task UpdatePayslipTest()
        {
            Guid payslipID = AutoFaker.Generate<Guid>();
            List<PayslipLines> payslipLines = new List<PayslipLines> { new PayslipLines() };
            var response = await instance.UpdatePayslipAsync(accessToken, xeroTenantId, payslipID, payslipLines);
            Assert.IsType<Payslips>(response);
        }
        
        /// <summary>
        /// Test UpdateSuperfund
        /// </summary>
        [Fact]
        public async Task UpdateSuperfundTest()
        {
            Guid superFundID = AutoFaker.Generate<Guid>();
            List<SuperFund> superFund = new List<SuperFund> { new SuperFund() };
            var response = await instance.UpdateSuperfundAsync(accessToken, xeroTenantId, superFundID, superFund);
            Assert.IsType<SuperFunds>(response);
        }
        
        /// <summary>
        /// Test UpdateTimesheet
        /// </summary>
        [Fact]
        public async Task UpdateTimesheetTest()
        {
            Guid timesheetID = AutoFaker.Generate<Guid>();
            List<Timesheet> timesheet = new List<Timesheet> { new Timesheet() };
            var response = await instance.UpdateTimesheetAsync(accessToken, xeroTenantId, timesheetID, timesheet);
            Assert.IsType<Timesheets>(response);
        }
        
    }

}
