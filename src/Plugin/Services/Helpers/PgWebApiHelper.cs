using System;
using System.Collections.Generic;
using Septa.PgNopIntegration.Plugin.Common.DTO;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using System.Web.Http;
using System.Net.Http.Headers;

namespace Septa.PgNopIntegration.Plugin.Services.Helpers
{
    public partial class PgProductWebApiHelper<T> : IPgProductWebApiHelper<T>
    {
        # region Ctor

        public PgProductWebApiHelper()
        {
            _httpClinet = new HttpClient();
            _httpClinet.DefaultRequestHeaders.Accept.Clear();
            _httpClinet.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        # endregion

        # region Fields
        private readonly HttpClient _httpClinet;
        public string Url { get; set; }
        # endregion

        # region Methods

        public virtual IEnumerable<T> GetAllProductsByLasSyncDate(DateTime lastSyncDate)
        {
            if (string.IsNullOrEmpty(Url))
                throw new ArgumentNullException("Url is null or empry");

            IEnumerable<T> productList = null;
            HttpResponseMessage response = _httpClinet.GetAsync(Url + lastSyncDate).Result;

            if (response.IsSuccessStatusCode)
            {
                var serializedObject = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                productList = JsonConvert.DeserializeObject<IEnumerable<T>>(serializedObject.ToString());
            }
            else if (response.StatusCode == HttpStatusCode.NotFound)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            else if (response.StatusCode == HttpStatusCode.InternalServerError)
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            else if(response.StatusCode==HttpStatusCode.ServiceUnavailable)
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
                throw new HttpResponseException(HttpStatusCode.Unauthorized);


            return productList;
        }

        #endregion

    }
}
