using API_VNG.Repository.KhoVungMien;
using Microsoft.AspNetCore.Mvc;
using VNG.Business.Models.Public;
using VNG.Business.Models.VungMien;
using VNG.Business.Utils;

namespace VNG_API.Controllers
{

    [Produces("application/json")]
    [Route("[controller]/[Action]")]
    public class KhoVungMienController : Controller
    {
        private readonly IKhoVungMienRepository _khoVungMienRepository;
        public KhoVungMienController(IKhoVungMienRepository khoVungMienRepository)
        {
            _khoVungMienRepository = khoVungMienRepository;
        }

        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(VM_NhapKho))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult VM_NhapKho([FromBody] NhapKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoVungMienRepository.VM_NhapKho(model);
                if (kq != null)
                {
                    result.Message = "Thành Công";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                else
                {
                    result.Message = "Lỗi Cập Nhật!!";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                return Ok(result);
            }
            else
            {
                result.Message = "Thất bại!!";
                result.StatusCode = 400;
                result.Result = null;
                return Ok(result);
            }
        }

        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(VM_XuatKho))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult VM_XuatKho([FromBody] XuatKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoVungMienRepository.VM_XuatKho(model);
                if (kq != null)
                {
                    result.Message = "Thành Công";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                else
                {
                    result.Message = "Lỗi Cập Nhật!!";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                return Ok(result);
            }
            else
            {
                result.Message = "Thất bại!!";
                result.StatusCode = 400;
                result.Result = null;
                return Ok(result);
            }
        }

        /// <summary>
        /// Create by Tri Minh, Date: 30/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(VM_XuatKhoTraKhoTong))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult VM_XuatKhoTraKhoTong([FromBody] XuatKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoVungMienRepository.VM_XuatKhoTraKhoTong(model);
                if (kq != null)
                {
                    result.Message = "Thành Công";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                else
                {
                    result.Message = "Lỗi Cập Nhật!!";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                return Ok(result);
            }
            else
            {
                result.Message = "Thất bại!!";
                result.StatusCode = 400;
                result.Result = null;
                return Ok(result);
            }
        }

        /// <summary>
        /// Create by Tri Minh, Date: 30/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(VM_VungMienXuatCuaHang))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult VM_VungMienXuatCuaHang([FromBody] VM_YeuCauCuaHang_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoVungMienRepository.VM_VungMienXuatCuaHang(model);
                if (kq != null)
                {
                    result.Message = "Thành Công";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                else
                {
                    result.Message = "Lỗi Cập Nhật!!";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                return Ok(result);
            }
            else
            {
                result.Message = "Thất bại!!";
                result.StatusCode = 400;
                result.Result = null;
                return Ok(result);
            }
        }

        /// <summary>
        /// Create by Tri Minh, Date: 29/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(VM_VanChuyen))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult VM_VanChuyen([FromBody] VM_VanChuyen_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoVungMienRepository.VM_VanChuyen(model);
                if (kq != null)
                {
                    result.Message = "Thành Công";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                else
                {
                    result.Message = "Lỗi Cập Nhật!!";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                return Ok(result);
            }
            else
            {
                result.Message = "Thất bại!!";
                result.StatusCode = 400;
                result.Result = null;
                return Ok(result);
            }
        }

        /// <summary>
        /// Create by Tri Minh, Date: 28/08/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(VM_TonKho))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult VM_TonKho([FromBody] VM_TonKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoVungMienRepository.VM_TonKho(model);
                if (kq != null)
                {
                    result.Message = "Thành Công";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                else
                {
                    result.Message = "Lỗi Cập Nhật!!";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                return Ok(result);
            }
            else
            {
                result.Message = "Thất bại!!";
                result.StatusCode = 400;
                result.Result = null;
                return Ok(result);
            }
        }

        /// <summary>
        /// Create by Tri Minh, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(VM_VanChuyen_HangLoi))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult VM_VanChuyen_HangLoi([FromBody] VM_VanChuyen_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoVungMienRepository.VM_VanChuyen_HangLoi(model);
                if (kq != null)
                {
                    result.Message = "Thành Công";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                else
                {
                    result.Message = "Lỗi Cập Nhật!!";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                return Ok(result);
            }
            else
            {
                result.Message = "Thất bại!!";
                result.StatusCode = 400;
                result.Result = null;
                return Ok(result);
            }
        }

        /// <summary>
        /// Create by Tri Minh, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(VM_XuatLoi))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult VM_XuatLoi([FromBody] XuatKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoVungMienRepository.VM_XuatLoi(model);
                if (kq != null)
                {
                    result.Message = "Thành Công";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                else
                {
                    result.Message = "Lỗi Cập Nhật!!";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                return Ok(result);
            }
            else
            {
                result.Message = "Thất bại!!";
                result.StatusCode = 400;
                result.Result = null;
                return Ok(result);
            }
        }

        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(VM_NhapLoi))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult VM_NhapLoi([FromBody] NhapKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoVungMienRepository.VM_NhapLoi(model);
                if (kq != null)
                {
                    result.Message = "Thành Công";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                else
                {
                    result.Message = "Lỗi Cập Nhật!!";
                    result.StatusCode = 200;
                    result.Result = kq;
                }
                return Ok(result);
            }
            else
            {
                result.Message = "Thất bại!!";
                result.StatusCode = 400;
                result.Result = null;
                return Ok(result);
            }
        }



        /// <summary>
        /// Create By Duy Tan
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(VM_NhapChinhKho))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult VM_NhapChinhKho([FromBody] NhapKho_ViewModel model)
        {

            var result = new CustomJsonResult();
            if (model != null)
            {
                var lst = _khoVungMienRepository.VM_NhapChinhKho(model);
                if (lst != null)
                {
                    result.StatusCode = 200;
                    result.Result = lst;
                    result.Message = "Thành công";
                    return Ok(result);

                }
            }

            result.Message = "Không thành công";
            result.Optional = 0;
            return Ok(result);


        }

        /// <summary>
        /// Create By Duy Tan
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(VM_XuatChinhKho))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult VM_XuatChinhKho([FromBody] XuatKho_ViewModel model)
        {

            var result = new CustomJsonResult();
            if (model != null)
            {
                var lst = _khoVungMienRepository.VM_XuatChinhKho(model);
                if (lst != null)
                {
                    result.StatusCode = 200;
                    result.Result = lst;
                    result.Message = "Thành công";
                    return Ok(result);

                }
            }

            result.Message = "Không thành công";
            result.Optional = 0;
            return Ok(result);


        }

        /// <summary>
        /// Create By Duy Tan, Date:  03/03/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(VM_TonKho_BaoCao))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult VM_TonKho_BaoCao([FromBody] VM_TonKho_BaoCao_ViewModel model)
        {

            var result = new CustomJsonResult();
            if (model != null)
            {
                var lst = _khoVungMienRepository.VM_TonKho_BaoCao(model);
                if (lst != null)
                {
                    result.StatusCode = 200;
                    result.Result = lst;
                    result.Message = "Thành công";
                    return Ok(result);

                }
            }

            result.Message = "Không thành công";
            result.Optional = 0;
            return Ok(result);
        }

        /// <summary>
        /// Create by Duy Tan, Date: 06/03/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(VM_DinhMuc_BaoCao))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult VM_DinhMuc_BaoCao([FromBody] VM_DinhMuc_BaoCao_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var lst = _khoVungMienRepository.VM_DinhMuc_BaoCao(model);
                if (lst != null)
                {
                    result.StatusCode = 200;
                    result.Result = lst;
                    result.Message = "Thành công";
                    return Ok(result);

                }
            }
            result.Message = "Không thành công";
            result.Optional = 0;
            return Ok(result);
        }
    }
}
