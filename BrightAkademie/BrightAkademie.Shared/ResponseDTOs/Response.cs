using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BrightAkademie.Shared.ResponseDTOs
{
    public class Response<T>
    {
        public T Data { get; set; }
        public List<string> Errors { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        [JsonIgnore]
        public bool IsSucceeded { get; set; }

        /// <summary>
        /// Bu metot, işlemin başarılı olduğu durumlarda başarılı bir cevapla birlikte veriyive durum kodunu döndürmek için kullanılır.
        /// </summary>
        /// <param name="data">Geri döndürülecek veri</param>
        /// <param name="statusCode">Geri döndürülecek durum kodu ör: 201, 401 vs</param>
        /// <returns>Response<typeparamref name="T"/>.</returns>
        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T>
            {
                Data = data,
                StatusCode = statusCode,
                IsSucceeded = true
            };
        }
        /// <summary>
        /// Bu metot, geriye başarılı bir cevap olarak sadece durum kodu döndürmek için kullanılır.
        /// </summary>
        /// <param name="statusCode">Geri döndürülecek durum kodu</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Success(int statusCode)
        {
            return new Response<T>
            {
                Data = default(T),
                StatusCode = statusCode,
                IsSucceeded = true
            };
        }

        /// <summary>
        /// Bu metot, geriye başarısız bir cevap olarak hata listesini ve durum kodurnu döndürmek için kullanılır.
        /// </summary>
        /// <param name="errors">Döndürülecek hata listesi</param>
        /// <param name="statusCode">Döndürülecek durum kodu ör: 401, 503 vb.</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Fail(List<string> errors, int statusCode)
        {
            return new Response<T>
            {
                Errors = errors,
                StatusCode = statusCode,
                IsSucceeded = false
            };
        }

        /// <summary>
        /// Bu metot, geriye başarısız bir cevap olarak içinde bir hata olan hata listesini ve durum kodurnu döndürmek için kullanılır.
        /// </summary>
        /// <param name="errors">Döndürülecek hata listesi</param>
        /// <param name="statusCode">Döndürülecek durum kodu ör: 401, 503 vb.</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Fail(string error, int statusCode)
        {
            return new Response<T>
            {
                Errors = new List<string> { error },
                StatusCode = statusCode,
                IsSucceeded = false
            };
        }
    }
}
