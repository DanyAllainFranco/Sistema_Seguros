﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SegurosFYP_WEB.Models;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using SegurosFYP_WEB.Services;
using ServiceStack.Configuration;
using SegurosFYP;
using SegurosFYP_WEB.WebAPI;

namespace SegurosFYP.WebAPI
{
    public class API
    {
        private readonly HttpClient _client;
        private readonly Cliente _url;
        private readonly IHttpContextAccessor _httpContext;
        public API(
                IHttpContextAccessor httpContext,
                IOptions<Cliente> url
        )
        {
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };
            _client = new HttpClient(httpClientHandler);

            _httpContext = httpContext;
            _url = url.Value;
            _client.BaseAddress = new Uri(_url.Url);
            _client.Timeout = TimeSpan.FromSeconds(10);
        }

        public async Task<ApiResult<B>> Get<A,B>(Action<ApiCallConfiguration<A>> action, string token = null)
        {
            var config = new ApiCallConfiguration<A>();
            var result = new ApiResult<B>();
            try
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                action(config);
                var response = await _client.GetAsync(config.PathWithQueryStrings);
                var content = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ApiResult<B>>(content);
                if (result != null)
                {
                    result.Path = config.Path;
                    result.StatusCode = response.StatusCode;
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = Helpers.GetMessage(ex);
            }
            return result;
        }

        public async Task<ApiResult<B>> Post<A,B>(Action<ApiCallConfiguration<A>> action, string token = null)
        {
            var config = new ApiCallConfiguration<A>();
            var result = new ApiResult<B>();
            try
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                action(config);
                var responseData = await _client.PostAsync(config.PathWithQueryStrings, config.ContentJson);
                var content = await responseData.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ApiResult<B>>(content);
                result.Path = config.Path;
                result.StatusCode = responseData.StatusCode;

                if (responseData.StatusCode == HttpStatusCode.OK)
                    result.Success = true;
                else
                    result.Success = false;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = Helpers.GetMessage(ex);
            }
            return result;
        }

        public async Task<ApiResult<B>> Put<A,B>(Action<ApiCallConfiguration<A>> action, string token = null)
        {
            var config = new ApiCallConfiguration<A>();
            var result = new ApiResult<B>();
            try
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                action(config);

                var response = await _client.PutAsync(config.PathWithQueryStrings, config.ContentJson);
                var content = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ApiResult<B>>(content);
                result.Path = config.Path;
                result.StatusCode = response.StatusCode;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = Helpers.GetMessage(ex);
            }

            return result;
        }

        public async Task<ApiResult<B>> Delete<A,B>(Action<ApiCallConfiguration<A>> action, string token = null)
        {
            var config = new ApiCallConfiguration<A>();
            var result = new ApiResult<B>();
            try
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                action(config);

                var response = await _client.DeleteAsync(config.PathWithQueryStrings);
                var content = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ApiResult<B>>(content);
                result.Path = config.Path;
                result.StatusCode = response.StatusCode;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = Helpers.GetMessage(ex);
            }

            return result;
        }

    }
}

