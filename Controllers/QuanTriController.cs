using System;
using System.Linq;
using API_VNG.Repository.QuanTri;
using Microsoft.AspNetCore.Mvc;
using VNG.Business.Models.CuaHang;
using VNG.Business.Models.QuanTri;
using VNG.Business.Utils;

namespace VNG_API.Controllers
{

    [Produces("application/json")]
    [Route("[controller]/[Action]")]
    public class QuanTriController : Controller
    {
        private readonly IQuanTriRepository _quanTriRepository;
        public QuanTriController(IQuanTriRepository quanTriRepository)
        {
            _quanTriRepository = quanTriRepository;
        }

        /// <summary>
        /// Create by Tri Minh, Date: 22/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(QT_Kieu))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult QT_Kieu([FromBody] QT_Kieu_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _quanTriRepository.QT_Kieu(model);
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
        /// Create by Tri Minh, Date: 22/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(QT_NhanVien))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult QT_NhanVien([FromBody] QT_NhanVien_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _quanTriRepository.QT_NhanVien(model);
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
        /// Create by Tri Minh, Date: 03/09/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(QT_DinhMuc))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult QT_DinhMuc([FromBody] QT_DinhMuc_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _quanTriRepository.QT_DinhMuc(model);
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
        /// Create by Tri Minh, Date: 15/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(QT_DinhMucChiTiet))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult QT_DinhMucChiTiet([FromBody] QT_DinhMuc_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _quanTriRepository.QT_DinhMucChiTiet(model);
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
        [HttpPost(Name = nameof(QT_QuanLyGia))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult QT_QuanLyGia([FromBody] QT_QuanLyGia_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _quanTriRepository.QT_QuanLyGia(model);
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
        /// Create by Tri Minh, Date: 18/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(QT_KhuyenMai))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult QT_KhuyenMai([FromBody] QT_SanPhamKhuyenMai_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _quanTriRepository.QT_KhuyenMai(model);
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
        ///  Create by Tri Minh, Date: 24/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(QT_ChanXuat))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult QT_ChanXuat([FromBody] QT_ChanXuat_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _quanTriRepository.QT_ChanXuat(model);
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
        /// Create by Duy Tan - Date: 2/12/2020
        /// </summary>
        /// <param name="model">
        /// </param>
        /// <returns>
        /// </returns>
        [HttpPost(Name = nameof(QT_QuyDinhTinhDiem))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult QT_QuyDinhTinhDiem([FromBody] QT_QuyDinhTinhDiem_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _quanTriRepository.QT_QuyDinhTinhDiem(model);
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
        /// <param name="model">
        /// </param>
        /// <returns>
        /// </returns>
        [HttpPost(Name = nameof(QT_QuyDinhDoiTra))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult QT_QuyDinhDoiTra([FromBody] QT_QuyDinhDoiTra_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _quanTriRepository.QT_QuyDinhDoiTra(model);
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
        /// Create by Tri Minh, Date: 24/12/2020
        /// </summary>
        /// <param name="model">
        /// </param>
        /// <returns>
        /// </returns>
        [HttpPost(Name = nameof(QT_QuanLyTichDiem))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult QT_QuanLyTichDiem([FromBody] QT_QuanLyTichDiem_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _quanTriRepository.QT_QuanLyTichDiem(model);
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
        ///  Create by Tri Minh, Date: 12/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(QT_LenhThuHoi))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult QT_LenhThuHoi([FromBody] QT_LenhThuHoi_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _quanTriRepository.QT_LenhThuHoi(model);
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
        /// Create by Tri Minh, Date: 23/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(QT_KhachHang))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult QT_KhachHang([FromBody] QT_KhachHang_ViewModel model)
        {
            var result = new CustomJsonResult();
            var lst = _quanTriRepository.QT_KhachHang(model);
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

        /// <summary>
        ///  Create by Tri Minh, Date: 14/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(QT_ThongKe_TongHop))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult QT_ThongKe_TongHop([FromBody] QT_ThongKeTongHop_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var kq = _quanTriRepository.QT_ThongKe_TongQuat(model);
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
        /// Create by Duy Tan, Date: 14/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(QT_PhatHanhPhieuTang))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult QT_PhatHanhPhieuTang([FromBody] QT_PhatHanhPhieuTang_ViewModel model)
        {
            var result = new CustomJsonResult();
            var lst = _quanTriRepository.QT_PhatHanhPhieuTang(model);
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

        /// <summary>
        /// Create by Tri Minh, Date: 01/02/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(QT_KetChuyenSoDu))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult QT_KetChuyenSoDu([FromBody] CH_TonKho_ViewModel model)
        {
            var result = new CustomJsonResult();
            var lst = _quanTriRepository.QT_KetChuyenSoDu(model);
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


        /// <summary>
        /// Create by Duy Tan, Date: 06/03/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(QT_DinhMuc_BaoCao))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult QT_DinhMuc_BaoCao([FromBody] QT_DinhMuc_BaoCao_ViewModel model)
        {
            var result = new CustomJsonResult();
            if (model != null)
            {
                var lst = _quanTriRepository.QT_DinhMuc_BaoCao(model);
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
