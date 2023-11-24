using Mango_Web.Utility;
using System.Net.Mime;
using System.Security.AccessControl;
using static Mango_Web.Utility.SD;
using ContentType = Mango_Web.Utility.SD.ContentType;

namespace Mango_Web.Models
{
   public class RequestDto
   {
      public ApiType ApiType { get; set; } = ApiType.GET;
      public string Url { get; set; }
      public object Data { get; set; }
      public string AccessToken { get; set; }

      public ContentType ContentType { get; set; } = ContentType.Json;
   }
}
