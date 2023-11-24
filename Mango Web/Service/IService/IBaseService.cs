using Mango_Web.Models;

namespace Mango_Web.Service.IService
{
   public interface IBaseService
   {
      Task<Mango.Web.Models.ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true);
   }
}
