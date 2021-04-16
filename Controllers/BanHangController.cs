using Microsoft.AspNetCore.Mvc;
using API_VNG.Repository.BanHang;
using VNG.Business.Models.CuaHang;
using VNG.Business.Utils;


namespace VNG_API.Controllers
{
    [Produces("application/json")]
    [Route("[controller]/[Action]")]
    public class BanHangController : Controller
    {
        private IBanHangRepository _banHangRepository;
        public BanHangController(IBanHangRepository banHangRepository)
        {
            _banHangRepository = banHangRepository;
        }

        /// <summary>
        /// Create by Tri Minh, Date: 24/12/2020
        /// </summary>
        /// <param name="model">
        /// </param>
        /// <returns>
        /// </returns>
        [HttpPost(Name = nameof(CH_BanHang))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_BanHang([FromBody] CH_BanHang_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _banHangRepository.CH_BanHang(model);
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
        /// Create by Tri Minh, Date: 14/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(CH_ChiTietPhieuTang))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_ChiTietPhieuTang([FromBody] CH_ChiTietPhieuTang_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _banHangRepository.CH_ChiTietPhieuTang(model);
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
        /// Create by Duy Tan, Date: 18/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(CH_PhieuTang))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_PhieuTang([FromBody] CH_PhieuTang_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _banHangRepository.CH_PhieuTang(model);
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
        /// Create by Tri Minh, Date: 13/08/2020
        /// </summary>
        /// <param name="model">
        /// </param>
        /// <returns>
        /// </returns>
        [HttpPost(Name = nameof(CH_DoiTraHang))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_DoiTraHang([FromBody] CH_DoiTraHang_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _banHangRepository.CH_DoiTraHang(model);
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
        /// <param name="model">
        /// </param>
        /// <returns>
        /// </returns>
        [HttpPost(Name = nameof(CH_BaoCaoKetCa))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_BaoCaoKetCa([FromBody] CH_BaoCaoKetCa_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _banHangRepository.CH_BaoCaoKetCa(model);
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
                    result.Result = null;
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
        /// Create by Tri Minh - Date: 23/10/2020
        /// </summary>
        /// <param name="model">
        /// </param>
        /// <returns>
        /// </returns>
        [HttpPost(Name = nameof(CH_GiaySua))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_GiaySua([FromBody] CH_GiaySua_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _banHangRepository.CH_GiaySua(model);
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
        /// Create by Tri Minh - Date: 18/12/2020
        /// </summary>
        /// <param name="model">
        /// </param>
        /// <returns>
        /// </returns>
        [HttpPost(Name = nameof(CH_ChiTietGiaySua))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_ChiTietGiaySua([FromBody] CH_ChiTietGiaySua_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _banHangRepository.CH_ChiTietGiaySua(model);
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
        /// Create by Trí Minh, Date: 18/11/2020, Duy Tan 12/1/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(CH_DatHangNoiBo))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_DatHangNoiBo([FromBody] CH_DatHangNoiBo_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _banHangRepository.CH_DatHangNoiBo(model);
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
        /// Create by Trí Minh, Date: 18/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(CH_ChiTietDatHangNoiBo))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_ChiTietDatHangNoiBo([FromBody] CH_ChiTietDatHangNoiBo_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _banHangRepository.CH_ChiTietDatHangNoiBo(model);
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


        #region CH_DatGiay

        [HttpPost(Name = nameof(CH_GiayDat))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_GiayDat([FromBody] CH_GiayDat_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var lst = _banHangRepository.CH_GiayDat(model);

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

        [HttpPost(Name = nameof(CH_GiayDatChiTiet))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_GiayDatChiTiet([FromBody] CH_GiayDatChiTiet_ViewModel model)
        {

            var result = new CustomJsonResult();
            if (model != null)
            {
                var lst = _banHangRepository.CH_GiayDatChiTiet(model);
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
        #endregion


        /// <summary>
        /// Create by Trí Minh, Date: 23/02/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(CH_GiaBan))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult CH_GiaBan([FromBody] CH_GiaBan_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _banHangRepository.CH_GiaBan(model);
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


    }
}