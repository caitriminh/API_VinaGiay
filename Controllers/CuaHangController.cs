using API_VNG.Repository.CuaHang;
using Microsoft.AspNetCore.Mvc;
using VNG.Business.Models.CuaHang;
using VNG.Business.Models.Public;
using VNG.Business.Utils;

namespace API_VNG.Controllers
{
    [Produces("application/json")]
    [Route("[controller]/[Action]")]
    public class CuaHangController : Controller
    {

        private readonly ICuaHangRepository _cuaHangRepository;
        public CuaHangController(ICuaHangRepository cuaHangRepository)
        {
            _cuaHangRepository = cuaHangRepository;
        }

        /// <summary>
        /// Create by Tri Minh, Date: 29/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(CH_XuatKho))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_XuatKho([FromBody] XuatKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _cuaHangRepository.CH_XuatKho(model);
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
        [HttpPost(Name = nameof(CH_NhapKho))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_NhapKho([FromBody] NhapKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _cuaHangRepository.CH_NhapKho(model);
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
        /// Create by Tri Minh, Date: 26/08/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(CH_VanChuyen))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_VanChuyen([FromBody] CH_VanChuyen_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _cuaHangRepository.CH_VanChuyen(model);
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
        ///  Create by Tri Minh, Date: 26/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(CH_TonKho))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_TonKho([FromBody] CH_TonKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _cuaHangRepository.CH_TonKho(model);
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
        /// Create by Tri Minh, Date: 04/09/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(CH_TraDinhMucVeVungMien))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_TraDinhMucVeVungMien([FromBody] XuatKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _cuaHangRepository.CH_TraDinhMucVeVungMien(model);
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
        /// Create by Tri Minh, Date: 04/09/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(CH_TonKhoDinhMuc))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_TonKhoDinhMuc([FromBody] CH_TonKhoDinhMuc_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _cuaHangRepository.CH_TonKhoDinhMuc(model);
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
        /// Create by Tri Minh, Date: 27/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(CH_QuanLyThuChi_ChiTiet))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_QuanLyThuChi_ChiTiet([FromBody] CH_QuanLyThuChi_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _cuaHangRepository.CH_QuanLyThuChi_ChiTiet(model);
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
        /// Create by Tri Minh, Date: 28/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(CH_QuanLyThuChi))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_QuanLyThuChi([FromBody] CH_QuanLyThuChi_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _cuaHangRepository.CH_QuanLyThuChi(model);
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
        [HttpPost(Name = nameof(CH_NhapLoi))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_NhapLoi([FromBody] NhapKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _cuaHangRepository.CH_NhapLoi(model);
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
        [HttpPost(Name = nameof(CH_XuatLoi))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_XuatLoi([FromBody] XuatKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _cuaHangRepository.CH_XuatLoi(model);
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
        [HttpPost(Name = nameof(CH_TonKhoLoi))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_TonKhoLoi([FromBody] CH_TonKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _cuaHangRepository.CH_TonKhoLoi(model);
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
            else///
            {
                result.Message = "Thất bại!!";
                result.StatusCode = 400;
                result.Result = null;
                return Ok(result);

            }
        }

        /// <summary>
        /// Create by Duy Tan, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(CH_NhapChinhKho))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_NhapChinhKho([FromBody] NhapKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var lst = _cuaHangRepository.CH_NhapDieuChinh(model);
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
        /// Create by Duy Tan, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(CH_XuatChinhKho))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_XuatChinhKho([FromBody] XuatKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var lst = _cuaHangRepository.CH_XuatDieuChinh(model);
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
        /// Create by Duy Tan, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(CH_TonKho_BaoCao))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_TonKho_BaoCao([FromBody] CH_TonKho_BaoCao_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var lst = _cuaHangRepository.CH_TonKho_BaoCao(model);
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
        /// Create by Duy Tan, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(CH_ThongKe))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_ThongKe([FromBody] CH_ThongKe_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var lst = _cuaHangRepository.CH_ThongKe(model);
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
        [HttpPost(Name = nameof(CH_DinhMuc_BaoCao))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_DinhMuc_BaoCao([FromBody] CH_DinhMuc_BaoCao_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var lst = _cuaHangRepository.CH_DinhMuc_BaoCao(model);
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
