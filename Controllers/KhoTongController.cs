using Microsoft.AspNetCore.Mvc;
using API_VNG.Repository.KhoTong;
using VNG.Business.Models.Public;
using VNG.Business.Utils;
using VNG.Business.Models.KhoTong;

namespace API_VNG.Controllers
{

    [Produces("application/json")]
    [Route("[controller]/[Action]")]
    public class KhoTongController : Controller
    {

        private readonly IKhoTongRepository _khoTongRepository;
        public KhoTongController(IKhoTongRepository khoTongRepository)
        {
            _khoTongRepository = khoTongRepository;
        }

        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(KT_NhapKho))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult KT_NhapKho([FromBody] NhapKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoTongRepository.KT_NhapKho(model);
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
        [HttpPost(Name = nameof(KT_XuatKho))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult KT_XuatKho([FromBody] XuatKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoTongRepository.KT_XuatKho(model);
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
        ///  Create by Tri Minh, Date: 28/09/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(KT_VanChuyen))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult KT_VanChuyen([FromBody] KT_VanChuyen_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoTongRepository.KT_VanChuyen(model);
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
        ///  Create by Tri Minh, Date: 02/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(KT_TonKho))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult KT_TonKho([FromBody] KT_TonKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoTongRepository.KT_TonKho(model);
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
        ///  Create by Tri Minh, Date: 02/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(KT_TonKhoThung))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult KT_TonKhoThung([FromBody] NhapKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoTongRepository.KT_TonKhoThung(model);
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
        ///  Create by Tri Minh, Date: 02/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(KT_YeuCauVungMien))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult KT_YeuCauVungMien([FromBody] KT_YeuCauVungMien_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoTongRepository.KT_YeuCauTuVungMien(model);
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
        ///  Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(KT_VanChuyen_HangLoi))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult KT_VanChuyen_HangLoi([FromBody] KT_VanChuyen_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoTongRepository.KT_VanChuyen_HangLoi(model);
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
        ///  Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(KT_NhapLoi))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult KT_NhapLoi([FromBody] NhapKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoTongRepository.KT_NhapLoi(model);
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
        ///  Create by Tri Minh, Date: 01/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(KT_XuatLoi))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult KT_XuatLoi([FromBody] XuatKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoTongRepository.KT_XuatLoi(model);
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
        ///  Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(KT_TonKhoLoi))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult KT_TonKhoLoi([FromBody] KT_TonKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoTongRepository.KT_TonKhoLoi(model);
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
        /// Create by Tri Minh, Date: 01/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(KT_NhapSale))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult KT_NhapSale([FromBody] NhapKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoTongRepository.KT_NhapSale(model);
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
        /// Create by Tri Minh, Date: 01/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(KT_XuatSale))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult KT_XuatSale([FromBody] XuatKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoTongRepository.KT_XuatSale(model);
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
        ///  Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(KT_TonKhoSale))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult KT_TonKhoSale([FromBody] KT_TonKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _khoTongRepository.KT_TonKhoSale(model);
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
        /// Create By Duy Tan, Date:  06/01/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(KT_NhapChinhKho))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult KT_NhapChinhKho([FromBody] NhapKho_ViewModel model)
        {

            var result = new CustomJsonResult();
            if (model != null)
            {
                var lst = _khoTongRepository.KT_NhapChinhKho(model);
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
        /// Create By Duy Tan, Date:  06/01/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(KT_XuatChinhKho))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult KT_XuatChinhKho([FromBody] XuatKho_ViewModel model)
        {

            var result = new CustomJsonResult();
            if (model != null)
            {
                var lst = _khoTongRepository.KT_XuatChinhKho(model);
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
        /// Create By Duy Tan, Date:  06/01/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(KT_TonKho_BaoCao))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult KT_TonKho_BaoCao([FromBody] KT_TonKho_BaoCao_ViewModel model)
        {

            var result = new CustomJsonResult();
            if (model != null)
            {
                var lst = _khoTongRepository.KT_TonKho_BaoCao(model);
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
