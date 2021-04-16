using API_VNG.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using VNG.Business.Models.System;
using VNG.Business.Utils;

namespace API_VNG.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class HeThongController : Controller
    {
        private IConfiguration Configuration;
        private readonly IHeThongRepository _heThongRepository;
        public HeThongController(IConfiguration config, IHeThongRepository heThongRepository)
        {
            _heThongRepository = heThongRepository;
            Configuration = config;
        }

        /// <summary>
        /// Create by Tri Minh, Date: 21/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces(typeof(CustomJsonResult))]
        public IActionResult CreateToken([FromBody] SYS_LoginByToken_ViewModel model)
        {
            var resultJson = new CustomJsonResult();
            var jwttoken = JwtTokenBuilder();
            resultJson.Result = jwttoken;
            resultJson.Message = "Đăng nhập thành công";
            resultJson.StatusCode = 200;
            resultJson.access_token = jwttoken;
            return Json(resultJson);
        }

        /// <summary>
        /// Create by Tri Minh, Date: 21/11/2020
        /// </summary>
        /// <returns></returns>
        private string JwtTokenBuilder()
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var jwtToken = new JwtSecurityToken(issuer: Configuration["JWT:issuer"],
                audience: Configuration["JWT:audience"], signingCredentials: credentials, expires: DateTime.Now.AddDays(1));
            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }

        /// <summary>
        /// Create by Tri Minh, Date: 10/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(ThongTin))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult ThongTin([FromBody] SYS_Info_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _heThongRepository.ThongTin(model);
                if (lst != null)
                {
                    result.Message = "Thành Công";
                    result.Optional = lst.Count();
                }
                else
                {
                    result.Message = "Không tìm thấy kết quả";
                    result.Optional = 0;
                }
                result.StatusCode = 200;
                result.Result = lst;
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        /// <summary>
        /// Create by Tri Minh, Date: 19/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DB_Log))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DB_Log([FromBody] SYS_DB_Log_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _heThongRepository.DB_Log(model);
                if (lst != null)
                {
                    result.Message = "Thành Công";
                    result.Optional = lst.Count();
                }
                else
                {
                    result.Message = "Không tìm thấy kết quả";
                    result.Optional = 0;
                }
                result.StatusCode = 200;
                result.Result = lst;
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        /// <summary>
        /// Create by Tri Minh, Date: 20/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(NguoiDung))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult NguoiDung([FromBody] SYS_User_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _heThongRepository.NguoiDung(model);
                if (lst != null)
                {
                    result.Message = "Thành Công";
                    result.Optional = lst.Count();
                }
                else
                {
                    result.Message = "Không tìm thấy kết quả";
                    result.Optional = 0;
                }
                result.StatusCode = 200;
                result.Result = lst;
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        /// <summary>
        /// Create by Tri Minh, Date: 21/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(ThietLap))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult ThietLap([FromBody] SYS_Setting_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _heThongRepository.ThietLap(model);
                if (lst != null)
                {
                    result.Message = "Thành Công";
                    result.Optional = lst.Count();
                }
                else
                {
                    result.Message = "Không tìm thấy kết quả";
                    result.Optional = 0;
                }
                result.StatusCode = 200;
                result.Result = lst;
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        /// <summary>
        /// Create by Tri Minh, Date: 22/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(PhanQuyen))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult PhanQuyen([FromBody] SYS_Permission_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _heThongRepository.PhanQuyen(model);
                if (lst != null)
                {
                    result.Message = "Thành Công";
                    result.Optional = lst.Count();
                }
                else
                {
                    result.Message = "Không tìm thấy kết quả";
                    result.Optional = 0;
                }
                result.StatusCode = 200;
                result.Result = lst;
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        /// <summary>
        /// Create by Tri Minh, Date: 22/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(NhomPhanQuyen))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult NhomPhanQuyen([FromBody] SYS_GroupPermission_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _heThongRepository.NhomPhanQuyen(model);
                if (lst != null)
                {
                    result.Message = "Thành Công";
                    result.Optional = lst.Count();
                }
                else
                {
                    result.Message = "Không tìm thấy kết quả";
                    result.Optional = 0;
                }
                result.StatusCode = 200;
                result.Result = lst;
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        /// <summary>
        /// Create by Tri Minh, Date: 06/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(HT_DangKyPhanMem))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult HT_DangKyPhanMem([FromBody] HT_DangKyPhanMem_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _heThongRepository.HT_DangKyPhanMem(model);
                if (lst != null)
                {
                    result.Message = "Thành Công";
                    result.Optional = lst.Count();
                }
                else
                {
                    result.Message = "Không tìm thấy kết quả";
                    result.Optional = 0;
                }
                result.StatusCode = 200;
                result.Result = lst;
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        /// <summary>
        /// Create by Tri Minh, Date: 06/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(HT_HuongDan))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult HT_HuongDan([FromBody] SYS_Tutorial_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _heThongRepository.HT_HuongDan(model);
                if (lst != null)
                {
                    result.Message = "Thành Công";
                    result.Optional = lst.Count();
                }
                else
                {
                    result.Message = "Không tìm thấy kết quả";
                    result.Optional = 0;
                }
                result.StatusCode = 200;
                result.Result = lst;
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return Ok(result);
        }
    }
}
