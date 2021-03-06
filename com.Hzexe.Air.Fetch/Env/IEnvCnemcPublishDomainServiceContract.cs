﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Text;
using Env.CnemcPublish.DAL;
using OpenRiaServices.DomainServices.Client;


namespace com.Hzexe.Air.Env.ContractLocal
{
    [ServiceContract]
    public interface IEnvCnemcPublishDomainServiceContract
    {
        // Methods
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/CommitChanges", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/CommitChangesResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/CommitChangesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
        IAsyncResult BeginCommitChanges(AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAirByCity", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAirByCityResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAirByCityDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
        IAsyncResult BeginGetAirByCity(int cityCode, AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllAQIPublishLive", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllAQIPublishLiveResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllAQIPublishLiveDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
        IAsyncResult BeginGetAllAQIPublishLive(AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllCityDayAQIModels", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllCityDayAQIModelsResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllCityDayAQIModelsDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
        IAsyncResult BeginGetAllCityDayAQIModels(AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllCityRealTimeAQIModelsDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllCityRealTimeAQIModels", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllCityRealTimeAQIModelsResponse")]
        IAsyncResult BeginGetAllCityRealTimeAQIModels(AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllIaqiPublishLive", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllIaqiPublishLiveResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllIaqiPublishLiveDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
        IAsyncResult BeginGetAllIaqiPublishLive(AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllModelCitiesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllModelCities", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllModelCitiesResponse")]
        IAsyncResult BeginGetAllModelCities(AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllStationMapModelsDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllStationMapModels", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAllStationMapModelsResponse")]
        IAsyncResult BeginGetAllStationMapModels(AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAqi24H", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAqi24HResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAqi24HDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
        IAsyncResult BeginGetAqi24H(AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAqi24HByIntDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAqi24HByInt", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAqi24HByIntResponse")]
        IAsyncResult BeginGetAqi24HByInt(int searchIndex, int count, AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAqi24HByTime", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAqi24HByTimeResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAqi24HByTimeDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
        IAsyncResult BeginGetAqi24HByTime(DateTime startTime, DateTime endTime, AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAQIChartValuesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAQIChartValues", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAQIChartValuesResponse"), WebGet]
        IAsyncResult BeginGetAQIChartValues(AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAQIDataPublishHistories", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAQIDataPublishHistoriesResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAQIDataPublishHistoriesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), WebGet]
        IAsyncResult BeginGetAQIDataPublishHistories(AsyncCallback callback, object asyncState);
        [WebGet, FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAQIDataPublishLivesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAQIDataPublishLives", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAQIDataPublishLivesResponse")]
        IAsyncResult BeginGetAQIDataPublishLives(AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAqiHistoryByCondition", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAqiHistoryByConditionResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAqiHistoryByConditionDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
        IAsyncResult BeginGetAqiHistoryByCondition(string stationCode, AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAqiHistoryByTimeDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAqiHistoryByTime", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAqiHistoryByTimeResponse")]
        IAsyncResult BeginGetAqiHistoryByTime(DateTime time, AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAreaAQIPublishLiveDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAreaAQIPublishLive", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAreaAQIPublishLiveResponse")]
        IAsyncResult BeginGetAreaAQIPublishLive(string area, AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAreaIaqiPublishLive", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetAreaIaqiPublishLiveResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetAreaIaqiPublishLiveDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
        IAsyncResult BeginGetAreaIaqiPublishLive(string area, AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetBlackLists", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetBlackListsResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetBlackListsDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), WebGet]
        IAsyncResult BeginGetBlackLists(AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCitiesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), WebGet, OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCities", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetCitiesResponse")]
        IAsyncResult BeginGetCities(AsyncCallback callback, object asyncState);
        [WebGet, FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCitiesByPidDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCitiesByPid", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetCitiesByPidResponse")]
        IAsyncResult BeginGetCitiesByPid(int pid, AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityAQIConfigsDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), WebGet, OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityAQIConfigs", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityAQIConfigsResponse")]
        IAsyncResult BeginGetCityAQIConfigs(AsyncCallback callback, object asyncState);
        [WebGet, FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityAQIModelsDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityAQIModels", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityAQIModelsResponse")]
        IAsyncResult BeginGetCityAQIModels(AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityAQIPublishHistories", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityAQIPublishHistoriesResponse"), WebGet, FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityAQIPublishHistoriesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
        IAsyncResult BeginGetCityAQIPublishHistories(AsyncCallback callback, object asyncState);
        [WebGet, FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityAQIPublishLivesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityAQIPublishLives", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityAQIPublishLivesResponse")]
        IAsyncResult BeginGetCityAQIPublishLives(AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityDayAqiHistoryByCondition", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityDayAqiHistoryByConditionResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityDayAqiHistoryByConditionDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
        IAsyncResult BeginGetCityDayAqiHistoryByCondition(int cityCode, AsyncCallback callback, object asyncState);
        [WebGet, OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityDayAQIModelByCitycode", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityDayAQIModelByCitycodeResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityDayAQIModelByCitycodeDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
        IAsyncResult BeginGetCityDayAQIModelByCitycode(int cityCode, AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityDayAQIPublishHistoriesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), WebGet, OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityDayAQIPublishHistories", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityDayAQIPublishHistoriesResponse")]
        IAsyncResult BeginGetCityDayAQIPublishHistories(AsyncCallback callback, object asyncState);
        [WebGet, FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityDayAQIPublishLivesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityDayAQIPublishLives", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityDayAQIPublishLivesResponse")]
        IAsyncResult BeginGetCityDayAQIPublishLives(AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityRealTimeAqiHistoryByCondition", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityRealTimeAqiHistoryByConditionResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityRealTimeAqiHistoryByConditionDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
        IAsyncResult BeginGetCityRealTimeAqiHistoryByCondition(int cityCode, AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityRealTimeAQIModelByCitycodeDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), WebGet, OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityRealTimeAQIModelByCitycode", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetCityRealTimeAQIModelByCitycodeResponse")]
        IAsyncResult BeginGetCityRealTimeAQIModelByCitycode(int cityCode, AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetExtentByPidDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetExtentByPid", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetExtentByPidResponse")]
        IAsyncResult BeginGetExtentByPid(int pid, AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetFuctionTablesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetFuctionTables", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetFuctionTablesResponse"), WebGet]
        IAsyncResult BeginGetFuctionTables(AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetIAQIDataPublishHistoriesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetIAQIDataPublishHistories", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetIAQIDataPublishHistoriesResponse"), WebGet]
        IAsyncResult BeginGetIAQIDataPublishHistories(AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetIAQIDataPublishLives", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetIAQIDataPublishLivesResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetIAQIDataPublishLivesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), WebGet]
        IAsyncResult BeginGetIAQIDataPublishLives(AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetIaqiHistoryByConditionDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetIaqiHistoryByCondition", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetIaqiHistoryByConditionResponse")]
        IAsyncResult BeginGetIaqiHistoryByCondition(string stationCode, AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetIaqiHistoryByNameAndTimeDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetIaqiHistoryByNameAndTime", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetIaqiHistoryByNameAndTimeResponse")]
        IAsyncResult BeginGetIaqiHistoryByNameAndTime(string positionName, string pollutantCode, string StartTime, string EndTime, AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetModelCityConfigs", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetModelCityConfigsResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetModelCityConfigsDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), WebGet]
        IAsyncResult BeginGetModelCityConfigs(AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetPidDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetPid", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetPidResponse")]
        IAsyncResult BeginGetPid(string cityname, AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetProvincePublishLives", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetProvincePublishLivesResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetProvincePublishLivesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
        IAsyncResult BeginGetProvincePublishLives(int pid, AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetProvincesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetProvinces", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetProvincesResponse"), WebGet]
        IAsyncResult BeginGetProvinces(AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetPublishLogsDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetPublishLogs", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetPublishLogsResponse"), WebGet]
        IAsyncResult BeginGetPublishLogs(AsyncCallback callback, object asyncState);
        [FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetServerTimeDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetServerTime", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetServerTimeResponse")]
        IAsyncResult BeginGetServerTime(AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetStationConfigs", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetStationConfigsResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetStationConfigsDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), WebGet]
        IAsyncResult BeginGetStationConfigs(AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetStationMapModel", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetStationMapModelResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetStationMapModelDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
        //IAsyncResult BeginGetStationMapModel(AsyncCallback callback, object asyncState);
        //[FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetStationModelByStationCodeDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetStationModelByStationCode", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetStationModelByStationCodeResponse"), WebGet]
        IAsyncResult BeginGetStationModelByStationCode(string stationCode, AsyncCallback callback, object asyncState);
        [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetSystemConfigs", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetSystemConfigsResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetSystemConfigsDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices"), WebGet]
        IAsyncResult BeginGetSystemConfigs(AsyncCallback callback, object asyncState);
        [WebGet, OperationContract(AsyncPattern = true, Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetWhiteLists", ReplyAction = "http://tempuri.org/EnvCnemcPublishDomainService/GetWhiteListsResponse"), FaultContract(typeof(DomainServiceFault), Action = "http://tempuri.org/EnvCnemcPublishDomainService/GetWhiteListsDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
        IAsyncResult BeginGetWhiteLists(AsyncCallback callback, object asyncState);
        bool EndCommitChanges(IAsyncResult result);
        byte[] EndGetAirByCity(IAsyncResult result);
        byte[] EndGetAllAQIPublishLive(IAsyncResult result);
        byte[] EndGetAllCityDayAQIModels(IAsyncResult result);
        byte[] EndGetAllCityRealTimeAQIModels(IAsyncResult result);
        byte[] EndGetAllIaqiPublishLive(IAsyncResult result);
        byte[] EndGetAllModelCities(IAsyncResult result);
        byte[] EndGetAllStationMapModels(IAsyncResult result);
        byte[] EndGetAqi24H(IAsyncResult result);
        byte[] EndGetAqi24HByInt(IAsyncResult result);
        byte[] EndGetAqi24HByTime(IAsyncResult result);
        QueryResult<AQIChartValue> EndGetAQIChartValues(IAsyncResult result);
        QueryResult<AQIDataPublishHistory> EndGetAQIDataPublishHistories(IAsyncResult result);
        QueryResult<AQIDataPublishLive> EndGetAQIDataPublishLives(IAsyncResult result);
        byte[] EndGetAqiHistoryByCondition(IAsyncResult result);
        byte[] EndGetAqiHistoryByTime(IAsyncResult result);
        byte[] EndGetAreaAQIPublishLive(IAsyncResult result);
        byte[] EndGetAreaIaqiPublishLive(IAsyncResult result);
        QueryResult<BlackList> EndGetBlackLists(IAsyncResult result);
        QueryResult<City> EndGetCities(IAsyncResult result);
        QueryResult<City> EndGetCitiesByPid(IAsyncResult result);
        QueryResult<CityAQIConfig> EndGetCityAQIConfigs(IAsyncResult result);
        QueryResult<CityAQIModel> EndGetCityAQIModels(IAsyncResult result);
        QueryResult<CityAQIPublishHistory> EndGetCityAQIPublishHistories(IAsyncResult result);
        QueryResult<CityAQIPublishLive> EndGetCityAQIPublishLives(IAsyncResult result);
        byte[] EndGetCityDayAqiHistoryByCondition(IAsyncResult result);
        QueryResult<CityDayAQIPublishLive> EndGetCityDayAQIModelByCitycode(IAsyncResult result);
        QueryResult<CityDayAQIPublishHistory> EndGetCityDayAQIPublishHistories(IAsyncResult result);
        QueryResult<CityDayAQIPublishLive> EndGetCityDayAQIPublishLives(IAsyncResult result);
        byte[] EndGetCityRealTimeAqiHistoryByCondition(IAsyncResult result);
        QueryResult<CityAQIPublishLive> EndGetCityRealTimeAQIModelByCitycode(IAsyncResult result);
        double[] EndGetExtentByPid(IAsyncResult result);
        QueryResult<FuctionTable> EndGetFuctionTables(IAsyncResult result);
        QueryResult<IAQIDataPublishHistory> EndGetIAQIDataPublishHistories(IAsyncResult result);
        QueryResult<IAQIDataPublishLive> EndGetIAQIDataPublishLives(IAsyncResult result);
        byte[] EndGetIaqiHistoryByCondition(IAsyncResult result);
        byte[] EndGetIaqiHistoryByNameAndTime(IAsyncResult result);
        QueryResult<ModelCityConfig> EndGetModelCityConfigs(IAsyncResult result);
        int EndGetPid(IAsyncResult result);
        byte[] EndGetProvincePublishLives(IAsyncResult result);
        QueryResult<Province> EndGetProvinces(IAsyncResult result);
        QueryResult<PublishLog> EndGetPublishLogs(IAsyncResult result);
        DateTime EndGetServerTime(IAsyncResult result);
        QueryResult<StationConfig> EndGetStationConfigs(IAsyncResult result);
        //StationMapModel EndGetStationMapModel(IAsyncResult result);
        QueryResult<AQIDataPublishLive> EndGetStationModelByStationCode(IAsyncResult result);
        QueryResult<SystemConfig> EndGetSystemConfigs(IAsyncResult result);
        QueryResult<WhiteList> EndGetWhiteLists(IAsyncResult result);
    }

    internal sealed class EnvCnemcPublishDomainContextEntityContainer : EntityContainer
    {
        // Methods
        public EnvCnemcPublishDomainContextEntityContainer()
        {
            base.CreateEntitySet<AQIChartValue>(0);
            base.CreateEntitySet<AQIDataPublishHistory>(0);
            base.CreateEntitySet<AQIDataPublishLive>(0);
            base.CreateEntitySet<BlackList>(0);
            base.CreateEntitySet<City>(0);
            base.CreateEntitySet<CityAQIConfig>(0);
            base.CreateEntitySet<CityAQIModel>(0);
            base.CreateEntitySet<CityAQIPublishHistory>(0);
            base.CreateEntitySet<CityAQIPublishLive>(0);
            base.CreateEntitySet<CityDayAQIPublishHistory>(0);
            base.CreateEntitySet<CityDayAQIPublishLive>(0);
            base.CreateEntitySet<FuctionTable>(0);
            base.CreateEntitySet<IAQIDataPublishHistory>(0);
            base.CreateEntitySet<IAQIDataPublishLive>(0);
            base.CreateEntitySet<ModelCityConfig>(0);
            base.CreateEntitySet<Province>(0);
            base.CreateEntitySet<PublishLog>(0);
            base.CreateEntitySet<StationConfig>(0);
            base.CreateEntitySet<SystemConfig>(0);
            base.CreateEntitySet<WhiteList>(0);
            return;
        }
    }



    public sealed class ClientContext : DomainContext
    {
        /// <summary>
        /// 初始化一个Context请求对象
        /// </summary>
        /// <remarks></remarks>
         public ClientContext()
            : this(new WebDomainClient<IEnvCnemcPublishDomainServiceContract>(new Uri("http://106.37.208.233:20035/ClientBin/Env-CnemcPublish-RiaServices-EnvCnemcPublishDomainService.svc")))
        {
           
        }

        private  ClientContext(DomainClient domainClient)
            : base(domainClient)
        {
            
            WebDomainClient<IEnvCnemcPublishDomainServiceContract> webDomainClient = (WebDomainClient<IEnvCnemcPublishDomainServiceContract>)DomainClient;
            CustomHeaderEndpointBehavior customHeaderEndpointBehavior = new CustomHeaderEndpointBehavior(this);
            webDomainClient.ChannelFactory.Endpoint.Behaviors.Add(customHeaderEndpointBehavior);
            webDomainClient.ChannelFactory.Endpoint.Binding.SendTimeout = new TimeSpan(0, 5, 0);
            webDomainClient.ChannelFactory.Endpoint.Binding.ReceiveTimeout = new TimeSpan(0, 5, 0);
        }


        public InvokeOperation<bool> CommitChanges()
        {
            base.ValidateMethod("CommitChanges", null);
            return (InvokeOperation<bool>)this.InvokeOperation("CommitChanges", typeof(bool), null, true, null, null);
        }

        public InvokeOperation<bool> CommitChanges(Action<InvokeOperation<bool>> callback, object userState)
        {
            base.ValidateMethod("CommitChanges", null);
            return this.InvokeOperation<bool>("CommitChanges", typeof(bool), null, true, callback, userState);
        }




        public InvokeOperation<byte[]> GetAirByCity(int cityCode)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("cityCode", (int)cityCode);
            base.ValidateMethod("GetAirByCity", dictionary);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetAirByCity", typeof(byte[]), dictionary, true, null, null);
        }

        public InvokeOperation<byte[]> GetAirByCity(int cityCode, Action<InvokeOperation<byte[]>> callback, object userState)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("cityCode", (int)cityCode);
            base.ValidateMethod("GetAirByCity", dictionary);
            return this.InvokeOperation<byte[]>("GetAirByCity", typeof(byte[]), dictionary, true, callback, userState);
        }

        public InvokeOperation<byte[]> GetAllAQIPublishLive()
        {
            base.ValidateMethod("GetAllAQIPublishLive", null);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetAllAQIPublishLive", typeof(byte[]), null, true, null, null);
        }

        public InvokeOperation<byte[]> GetAllAQIPublishLive(Action<InvokeOperation<byte[]>> callback, object userState)
        {
            base.ValidateMethod("GetAllAQIPublishLive", null);
            return this.InvokeOperation<byte[]>("GetAllAQIPublishLive", typeof(byte[]), null, true, callback, userState);
        }

        public InvokeOperation<byte[]> GetAllCityDayAQIModels()
        {
            base.ValidateMethod("GetAllCityDayAQIModels", null);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetAllCityDayAQIModels", typeof(byte[]), null, true, null, null);
        }

        public InvokeOperation<byte[]> GetAllCityDayAQIModels(Action<InvokeOperation<byte[]>> callback, object userState)
        {
            base.ValidateMethod("GetAllCityDayAQIModels", null);
            return this.InvokeOperation<byte[]>("GetAllCityDayAQIModels", typeof(byte[]), null, true, callback, userState);
        }

        public InvokeOperation<byte[]> GetAllCityRealTimeAQIModels()
        {
            base.ValidateMethod("GetAllCityRealTimeAQIModels", null);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetAllCityRealTimeAQIModels", typeof(byte[]), null, true, null, null);
        }

        public InvokeOperation<byte[]> GetAllCityRealTimeAQIModels(Action<InvokeOperation<byte[]>> callback, object userState)
        {
            base.ValidateMethod("GetAllCityRealTimeAQIModels", null);
            return this.InvokeOperation<byte[]>("GetAllCityRealTimeAQIModels", typeof(byte[]), null, true, callback, userState);
        }

        public InvokeOperation<byte[]> GetAllIaqiPublishLive()
        {
            base.ValidateMethod("GetAllIaqiPublishLive", null);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetAllIaqiPublishLive", typeof(byte[]), null, true, null, null);
        }

        public InvokeOperation<byte[]> GetAllIaqiPublishLive(Action<InvokeOperation<byte[]>> callback, object userState)
        {
            base.ValidateMethod("GetAllIaqiPublishLive", null);
            return this.InvokeOperation<byte[]>("GetAllIaqiPublishLive", typeof(byte[]), null, true, callback, userState);
        }

        public InvokeOperation<byte[]> GetAllModelCities()
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();



            base.ValidateMethod("GetAllModelCities", dictionary);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetAllModelCities", typeof(byte[]), dictionary, true, r =>
            {

                Debug.WriteLine("callback");

            }, this);
        }

        public InvokeOperation<byte[]> GetAllModelCities(Action<InvokeOperation<byte[]>> callback, object userState)
        {
            base.ValidateMethod("GetAllModelCities", null);
            return this.InvokeOperation<byte[]>("GetAllModelCities", typeof(byte[]), null, true, callback, userState);
        }

        public InvokeOperation<byte[]> GetAllStationMapModels()
        {
            base.ValidateMethod("GetAllStationMapModels", null);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetAllStationMapModels", typeof(byte[]), null, true, null, null);
        }

        public InvokeOperation<byte[]> GetAllStationMapModels(Action<InvokeOperation<byte[]>> callback, object userState)
        {
            base.ValidateMethod("GetAllStationMapModels", null);
            return this.InvokeOperation<byte[]>("GetAllStationMapModels", typeof(byte[]), null, true, callback, userState);
        }

        public InvokeOperation<byte[]> GetAqi24H()
        {
            base.ValidateMethod("GetAqi24H", null);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetAqi24H", typeof(byte[]), null, true, null, null);
        }

        public InvokeOperation<byte[]> GetAqi24H(Action<InvokeOperation<byte[]>> callback, object userState)
        {
            base.ValidateMethod("GetAqi24H", null);
            return this.InvokeOperation<byte[]>("GetAqi24H", typeof(byte[]), null, true, callback, userState);
        }

        public InvokeOperation<byte[]> GetAqi24HByInt(int searchIndex, int count)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("searchIndex", (int)searchIndex);
            dictionary.Add("count", (int)count);
            base.ValidateMethod("GetAqi24HByInt", dictionary);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetAqi24HByInt", typeof(byte[]), dictionary, true, null, null);
        }

        public InvokeOperation<byte[]> GetAqi24HByInt(int searchIndex, int count, Action<InvokeOperation<byte[]>> callback, object userState)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("searchIndex", (int)searchIndex);
            dictionary.Add("count", (int)count);
            base.ValidateMethod("GetAqi24HByInt", dictionary);
            return this.InvokeOperation<byte[]>("GetAqi24HByInt", typeof(byte[]), dictionary, true, callback, userState);
        }

        public InvokeOperation<byte[]> GetAqi24HByTime(DateTime startTime, DateTime endTime)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("startTime", (DateTime)startTime);
            dictionary.Add("endTime", (DateTime)endTime);
            base.ValidateMethod("GetAqi24HByTime", dictionary);




            return (InvokeOperation<byte[]>)this.InvokeOperation("GetAqi24HByTime", typeof(byte[]), dictionary, true, null, null);
        }

        public InvokeOperation<byte[]> GetAqi24HByTime(DateTime startTime, DateTime endTime, Action<InvokeOperation<byte[]>> callback, object userState)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("startTime", (DateTime)startTime);
            dictionary.Add("endTime", (DateTime)endTime);
            base.ValidateMethod("GetAqi24HByTime", dictionary);
            return this.InvokeOperation<byte[]>("GetAqi24HByTime", typeof(byte[]), dictionary, true, callback, userState);
        }

        public EntityQuery<AQIChartValue> GetAQIChartValuesQuery()
        {
            base.ValidateMethod("GetAQIChartValuesQuery", null);
            return base.CreateQuery<AQIChartValue>("GetAQIChartValues", null, false, true);
        }

        public EntityQuery<AQIDataPublishHistory> GetAQIDataPublishHistoriesQuery()
        {
            base.ValidateMethod("GetAQIDataPublishHistoriesQuery", null);
            return base.CreateQuery<AQIDataPublishHistory>("GetAQIDataPublishHistories", null, false, true);
        }

        public EntityQuery<AQIDataPublishLive> GetAQIDataPublishLivesQuery()
        {
            base.ValidateMethod("GetAQIDataPublishLivesQuery", null);
            return base.CreateQuery<AQIDataPublishLive>("GetAQIDataPublishLives", null, false, true);
        }

        public InvokeOperation<byte[]> GetAqiHistoryByCondition(string stationCode)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("stationCode", stationCode);
            base.ValidateMethod("GetAqiHistoryByCondition", dictionary);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetAqiHistoryByCondition", typeof(byte[]), dictionary, true, null, null);
        }

        public InvokeOperation<byte[]> GetAqiHistoryByCondition(string stationCode, Action<InvokeOperation<byte[]>> callback, object userState)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("stationCode", stationCode);
            base.ValidateMethod("GetAqiHistoryByCondition", dictionary);
            return this.InvokeOperation<byte[]>("GetAqiHistoryByCondition", typeof(byte[]), dictionary, true, callback, userState);
        }

        public InvokeOperation<byte[]> GetAqiHistoryByTime(DateTime time)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("time", (DateTime)time);
            base.ValidateMethod("GetAqiHistoryByTime", dictionary);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetAqiHistoryByTime", typeof(byte[]), dictionary, true, null, null);
        }

        public InvokeOperation<byte[]> GetAqiHistoryByTime(DateTime time, Action<InvokeOperation<byte[]>> callback, object userState)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("time", (DateTime)time);
            base.ValidateMethod("GetAqiHistoryByTime", dictionary);
            return this.InvokeOperation<byte[]>("GetAqiHistoryByTime", typeof(byte[]), dictionary, true, callback, userState);
        }

        public InvokeOperation<byte[]> GetAreaAQIPublishLive(string area)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("area", area);
            base.ValidateMethod("GetAreaAQIPublishLive", dictionary);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetAreaAQIPublishLive", typeof(byte[]), dictionary, true, null, null);
        }

        public InvokeOperation<byte[]> GetAreaAQIPublishLive(string area, Action<InvokeOperation<byte[]>> callback, object userState)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("area", area);
            base.ValidateMethod("GetAreaAQIPublishLive", dictionary);
            return this.InvokeOperation<byte[]>("GetAreaAQIPublishLive", typeof(byte[]), dictionary, true, callback, userState);
        }

        public InvokeOperation<byte[]> GetAreaIaqiPublishLive(string area)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("area", area);
            base.ValidateMethod("GetAreaIaqiPublishLive", dictionary);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetAreaIaqiPublishLive", typeof(byte[]), dictionary, true, null, null);
        }

        public InvokeOperation<byte[]> GetAreaIaqiPublishLive(string area, Action<InvokeOperation<byte[]>> callback, object userState)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("area", area);
            base.ValidateMethod("GetAreaIaqiPublishLive", dictionary);
            return this.InvokeOperation<byte[]>("GetAreaIaqiPublishLive", typeof(byte[]), dictionary, true, callback, userState);
        }

        public EntityQuery<BlackList> GetBlackListsQuery()
        {
            base.ValidateMethod("GetBlackListsQuery", null);
            return base.CreateQuery<BlackList>("GetBlackLists", null, false, true);
        }

        public EntityQuery<City> GetCitiesByPidQuery(int pid)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("pid", (int)pid);
            base.ValidateMethod("GetCitiesByPidQuery", dictionary);
            return base.CreateQuery<City>("GetCitiesByPid", dictionary, false, true);
        }

        public EntityQuery<City> GetCitiesQuery()
        {
            base.ValidateMethod("GetCitiesQuery", null);
            return base.CreateQuery<City>("GetCities", null, false, true);
        }

        public EntityQuery<CityAQIConfig> GetCityAQIConfigsQuery()
        {
            base.ValidateMethod("GetCityAQIConfigsQuery", null);
            return base.CreateQuery<CityAQIConfig>("GetCityAQIConfigs", null, false, true);
        }

        public EntityQuery<CityAQIModel> GetCityAQIModelsQuery()
        {
            base.ValidateMethod("GetCityAQIModelsQuery", null);
            return base.CreateQuery<CityAQIModel>("GetCityAQIModels", null, false, true);
        }

        public EntityQuery<CityAQIPublishHistory> GetCityAQIPublishHistoriesQuery()
        {
            base.ValidateMethod("GetCityAQIPublishHistoriesQuery", null);
            return base.CreateQuery<CityAQIPublishHistory>("GetCityAQIPublishHistories", null, false, true);
        }

        public EntityQuery<CityAQIPublishLive> GetCityAQIPublishLivesQuery()
        {
            base.ValidateMethod("GetCityAQIPublishLivesQuery", null);
            return base.CreateQuery<CityAQIPublishLive>("GetCityAQIPublishLives", null, false, true);
        }

        public InvokeOperation<byte[]> GetCityDayAqiHistoryByCondition(int cityCode)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("cityCode", (int)cityCode);
            base.ValidateMethod("GetCityDayAqiHistoryByCondition", dictionary);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetCityDayAqiHistoryByCondition", typeof(byte[]), dictionary, true, null, null);
        }

        public InvokeOperation<byte[]> GetCityDayAqiHistoryByCondition(int cityCode, Action<InvokeOperation<byte[]>> callback, object userState)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("cityCode", (int)cityCode);
            base.ValidateMethod("GetCityDayAqiHistoryByCondition", dictionary);
            return this.InvokeOperation<byte[]>("GetCityDayAqiHistoryByCondition", typeof(byte[]), dictionary, true, callback, userState);
        }

        public EntityQuery<CityDayAQIPublishLive> GetCityDayAQIModelByCitycodeQuery(int cityCode)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("cityCode", (int)cityCode);
            base.ValidateMethod("GetCityDayAQIModelByCitycodeQuery", dictionary);
            return base.CreateQuery<CityDayAQIPublishLive>("GetCityDayAQIModelByCitycode", dictionary, false, false);
        }

        public EntityQuery<CityDayAQIPublishHistory> GetCityDayAQIPublishHistoriesQuery()
        {
            base.ValidateMethod("GetCityDayAQIPublishHistoriesQuery", null);
            return base.CreateQuery<CityDayAQIPublishHistory>("GetCityDayAQIPublishHistories", null, false, true);
        }

        public EntityQuery<CityDayAQIPublishLive> GetCityDayAQIPublishLivesQuery()
        {
            base.ValidateMethod("GetCityDayAQIPublishLivesQuery", null);
            return base.CreateQuery<CityDayAQIPublishLive>("GetCityDayAQIPublishLives", null, false, true);
        }

        public InvokeOperation<byte[]> GetCityRealTimeAqiHistoryByCondition(int cityCode)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("cityCode", (int)cityCode);
            base.ValidateMethod("GetCityRealTimeAqiHistoryByCondition", dictionary);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetCityRealTimeAqiHistoryByCondition", typeof(byte[]), dictionary, true, null, null);
        }

        public InvokeOperation<byte[]> GetCityRealTimeAqiHistoryByCondition(int cityCode, Action<InvokeOperation<byte[]>> callback, object userState)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("cityCode", (int)cityCode);
            base.ValidateMethod("GetCityRealTimeAqiHistoryByCondition", dictionary);
            return this.InvokeOperation<byte[]>("GetCityRealTimeAqiHistoryByCondition", typeof(byte[]), dictionary, true, callback, userState);
        }

        public EntityQuery<CityAQIPublishLive> GetCityRealTimeAQIModelByCitycodeQuery(int cityCode)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("cityCode", (int)cityCode);
            base.ValidateMethod("GetCityRealTimeAQIModelByCitycodeQuery", dictionary);
            return base.CreateQuery<CityAQIPublishLive>("GetCityRealTimeAQIModelByCitycode", dictionary, false, false);
        }

        public InvokeOperation<double[]> GetExtentByPid(int pid)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("pid", (int)pid);
            base.ValidateMethod("GetExtentByPid", dictionary);
            return (InvokeOperation<double[]>)this.InvokeOperation("GetExtentByPid", typeof(double[]), dictionary, true, null, null);
        }

        public InvokeOperation<double[]> GetExtentByPid(int pid, Action<InvokeOperation<double[]>> callback, object userState)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("pid", (int)pid);
            base.ValidateMethod("GetExtentByPid", dictionary);
            return this.InvokeOperation<double[]>("GetExtentByPid", typeof(double[]), dictionary, true, callback, userState);
        }

        public EntityQuery<FuctionTable> GetFuctionTablesQuery()
        {
            base.ValidateMethod("GetFuctionTablesQuery", null);
            return base.CreateQuery<FuctionTable>("GetFuctionTables", null, false, true);
        }

        public EntityQuery<IAQIDataPublishHistory> GetIAQIDataPublishHistoriesQuery()
        {
            base.ValidateMethod("GetIAQIDataPublishHistoriesQuery", null);
            return base.CreateQuery<IAQIDataPublishHistory>("GetIAQIDataPublishHistories", null, false, true);
        }

        public EntityQuery<IAQIDataPublishLive> GetIAQIDataPublishLivesQuery()
        {
            base.ValidateMethod("GetIAQIDataPublishLivesQuery", null);
            return base.CreateQuery<IAQIDataPublishLive>("GetIAQIDataPublishLives", null, false, true);
        }

        public InvokeOperation<byte[]> GetIaqiHistoryByCondition(string stationCode)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("stationCode", stationCode);
            base.ValidateMethod("GetIaqiHistoryByCondition", dictionary);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetIaqiHistoryByCondition", typeof(byte[]), dictionary, true, null, null);
        }

        public InvokeOperation<byte[]> GetIaqiHistoryByCondition(string stationCode, Action<InvokeOperation<byte[]>> callback, object userState)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("stationCode", stationCode);
            base.ValidateMethod("GetIaqiHistoryByCondition", dictionary);
            return this.InvokeOperation<byte[]>("GetIaqiHistoryByCondition", typeof(byte[]), dictionary, true, callback, userState);
        }

        public InvokeOperation<byte[]> GetIaqiHistoryByNameAndTime(string positionName, string pollutantCode, string StartTime, string EndTime)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("positionName", positionName);
            dictionary.Add("pollutantCode", pollutantCode);
            dictionary.Add("StartTime", StartTime);
            dictionary.Add("EndTime", EndTime);
            base.ValidateMethod("GetIaqiHistoryByNameAndTime", dictionary);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetIaqiHistoryByNameAndTime", typeof(byte[]), dictionary, true, null, null);
        }

        public InvokeOperation<byte[]> GetIaqiHistoryByNameAndTime(string positionName, string pollutantCode, string StartTime, string EndTime, Action<InvokeOperation<byte[]>> callback, object userState)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("positionName", positionName);
            dictionary.Add("pollutantCode", pollutantCode);
            dictionary.Add("StartTime", StartTime);
            dictionary.Add("EndTime", EndTime);
            base.ValidateMethod("GetIaqiHistoryByNameAndTime", dictionary);
            return this.InvokeOperation<byte[]>("GetIaqiHistoryByNameAndTime", typeof(byte[]), dictionary, true, callback, userState);
        }

        public EntityQuery<ModelCityConfig> GetModelCityConfigsQuery()
        {
            base.ValidateMethod("GetModelCityConfigsQuery", null);
            return base.CreateQuery<ModelCityConfig>("GetModelCityConfigs", null, false, true);
        }

        public InvokeOperation<int> GetPid(string cityname)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("cityname", cityname);
            base.ValidateMethod("GetPid", dictionary);
            return (InvokeOperation<int>)this.InvokeOperation("GetPid", typeof(int), dictionary, true, null, null);
        }

        public InvokeOperation<int> GetPid(string cityname, Action<InvokeOperation<int>> callback, object userState)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("cityname", cityname);
            base.ValidateMethod("GetPid", dictionary);
            return this.InvokeOperation<int>("GetPid", typeof(int), dictionary, true, callback, userState);
        }

        public InvokeOperation<byte[]> GetProvincePublishLives(int pid)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("pid", (int)pid);
            base.ValidateMethod("GetProvincePublishLives", dictionary);
            return (InvokeOperation<byte[]>)this.InvokeOperation("GetProvincePublishLives", typeof(byte[]), dictionary, true, null, null);
        }

        public InvokeOperation<byte[]> GetProvincePublishLives(int pid, Action<InvokeOperation<byte[]>> callback, object userState)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("pid", (int)pid);
            base.ValidateMethod("GetProvincePublishLives", dictionary);
            return this.InvokeOperation<byte[]>("GetProvincePublishLives", typeof(byte[]), dictionary, true, callback, userState);
        }

        public EntityQuery<Province> GetProvincesQuery()
        {
            base.ValidateMethod("GetProvincesQuery", null);
            return base.CreateQuery<Province>("GetProvinces", null, false, true);
        }

        public EntityQuery<PublishLog> GetPublishLogsQuery()
        {
            base.ValidateMethod("GetPublishLogsQuery", null);
            return base.CreateQuery<PublishLog>("GetPublishLogs", null, false, true);
        }

        public InvokeOperation<DateTime> GetServerTime()
        {
            base.ValidateMethod("GetServerTime", null);
            return (InvokeOperation<DateTime>)this.InvokeOperation("GetServerTime", typeof(DateTime), null, true, null, null);
        }

        public InvokeOperation<DateTime> GetServerTime(Action<InvokeOperation<DateTime>> callback, object userState)
        {
            base.ValidateMethod("GetServerTime", null);
            return this.InvokeOperation<DateTime>("GetServerTime", typeof(DateTime), null, true, callback, userState);
        }

        public EntityQuery<StationConfig> GetStationConfigsQuery()
        {
            base.ValidateMethod("GetStationConfigsQuery", null);
            return base.CreateQuery<StationConfig>("GetStationConfigs", null, false, true);
        }

        //public InvokeOperation<StationMapModel> GetStationMapModel()
        //{
        //    base.ValidateMethod("GetStationMapModel", null);
        //    return (InvokeOperation<StationMapModel>)this.InvokeOperation("GetStationMapModel", typeof(StationMapModel), null, true, null, null);
        //}

        //public InvokeOperation<StationMapModel> GetStationMapModel(Action<InvokeOperation<StationMapModel>> callback, object userState)
        //{
        //    base.ValidateMethod("GetStationMapModel", null);
        //    return this.InvokeOperation<StationMapModel>("GetStationMapModel", typeof(StationMapModel), null, true, callback, userState);
        //}

        public EntityQuery<AQIDataPublishLive> GetStationModelByStationCodeQuery(string stationCode)
        {
            Dictionary<string, object> dictionary;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("stationCode", stationCode);
            base.ValidateMethod("GetStationModelByStationCodeQuery", dictionary);
            return base.CreateQuery<AQIDataPublishLive>("GetStationModelByStationCode", dictionary, false, false);
        }

        public EntityQuery<SystemConfig> GetSystemConfigsQuery()
        {
            base.ValidateMethod("GetSystemConfigsQuery", null);
            return base.CreateQuery<SystemConfig>("GetSystemConfigs", null, false, true);
        }

        public EntityQuery<WhiteList> GetWhiteListsQuery()
        {
            base.ValidateMethod("GetWhiteListsQuery", null);
            return base.CreateQuery<WhiteList>("GetWhiteLists", null, false, true);
        }

        // Properties
        public EntitySet<AQIChartValue> AQIChartValues
        {
            get
            {
                return base.EntityContainer.GetEntitySet<AQIChartValue>();
            }
        }

        public EntitySet<AQIDataPublishHistory> AQIDataPublishHistories
        {
            get
            {
                return base.EntityContainer.GetEntitySet<AQIDataPublishHistory>();
            }
        }

        public EntitySet<AQIDataPublishLive> AQIDataPublishLives
        {
            get
            {
                return base.EntityContainer.GetEntitySet<AQIDataPublishLive>();
            }
        }

        public EntitySet<BlackList> BlackLists
        {
            get
            {
                return base.EntityContainer.GetEntitySet<BlackList>();
            }
        }

        public EntitySet<City> Cities
        {
            get
            {
                return base.EntityContainer.GetEntitySet<City>();
            }
        }

        public EntitySet<CityAQIConfig> CityAQIConfigs
        {
            get
            {
                return base.EntityContainer.GetEntitySet<CityAQIConfig>();
            }
        }

        public EntitySet<CityAQIModel> CityAQIModels
        {
            get
            {
                return base.EntityContainer.GetEntitySet<CityAQIModel>();
            }
        }

        public EntitySet<CityAQIPublishHistory> CityAQIPublishHistories
        {
            get
            {
                return base.EntityContainer.GetEntitySet<CityAQIPublishHistory>();
            }
        }

        public EntitySet<CityAQIPublishLive> CityAQIPublishLives
        {
            get
            {
                return base.EntityContainer.GetEntitySet<CityAQIPublishLive>();
            }
        }

        public EntitySet<CityDayAQIPublishHistory> CityDayAQIPublishHistories
        {
            get
            {
                return base.EntityContainer.GetEntitySet<CityDayAQIPublishHistory>();
            }
        }

        public EntitySet<CityDayAQIPublishLive> CityDayAQIPublishLives
        {
            get
            {
                return base.EntityContainer.GetEntitySet<CityDayAQIPublishLive>();
            }
        }

        public EntitySet<FuctionTable> FuctionTables
        {
            get
            {
                return base.EntityContainer.GetEntitySet<FuctionTable>();
            }
        }

        public EntitySet<IAQIDataPublishHistory> IAQIDataPublishHistories
        {
            get
            {
                return base.EntityContainer.GetEntitySet<IAQIDataPublishHistory>();
            }
        }

        public EntitySet<IAQIDataPublishLive> IAQIDataPublishLives
        {
            get
            {
                return base.EntityContainer.GetEntitySet<IAQIDataPublishLive>();
            }
        }

        public EntitySet<ModelCityConfig> ModelCityConfigs
        {
            get
            {
                return base.EntityContainer.GetEntitySet<ModelCityConfig>();
            }
        }

        public EntitySet<Province> Provinces
        {
            get
            {
                return base.EntityContainer.GetEntitySet<Province>();
            }
        }

        public EntitySet<PublishLog> PublishLogs
        {
            get
            {
                return base.EntityContainer.GetEntitySet<PublishLog>();
            }
        }

        public EntitySet<StationConfig> StationConfigs
        {
            get
            {
                return base.EntityContainer.GetEntitySet<StationConfig>();
            }
        }

        public EntitySet<SystemConfig> SystemConfigs
        {
            get
            {
                return base.EntityContainer.GetEntitySet<SystemConfig>();
            }
        }

        public EntitySet<WhiteList> WhiteLists
        {
            get
            {
                return base.EntityContainer.GetEntitySet<WhiteList>();
            }
        }







        protected override EntityContainer CreateEntityContainer()
        {
            return new EnvCnemcPublishDomainContextEntityContainer();
        }

    }




    public class CustomHeaderEndpointBehavior : IEndpointBehavior
    {
        ClientContext _Ctx;

        public CustomHeaderEndpointBehavior(ClientContext ctx)
        {
            this._Ctx = ctx;
        }

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters) { }
        public void ApplyClientBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime)
        {
            clientRuntime.MessageInspectors.Add(new CustomHeaderMessageInspector(this._Ctx));
        }
        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
        public void Validate(ServiceEndpoint endpoint) { }
    }

    public class CustomHeaderMessageInspector : IClientMessageInspector
    {
        ClientContext _Ctx;

        public CustomHeaderMessageInspector(ClientContext ctx)
        {
            this._Ctx = ctx;
        }

        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState) { }
        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, IClientChannel channel)
        {
            string myHeaderName = "Referer";
            string myheaderValue = "http://113.108.142.147:20035/emcpublish/ClientBin/cnemc.xap";

            HttpRequestMessageProperty property = (HttpRequestMessageProperty)request.Properties[HttpRequestMessageProperty.Name];
            property.Headers[myHeaderName] = myheaderValue;
            return null;
        }
    }
}
