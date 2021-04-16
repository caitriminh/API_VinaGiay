using System;
using System.Linq;
using API_VNG.Repository.DanhMuc;
using Microsoft.AspNetCore.Mvc;
using VNG.Business.Models.DTA;
using VNG.Business.Utils;

namespace API_VNG.Controllers
{

    [Produces("application/json")]
    [Route("[controller]/[Action]")]
    public class DanhMucController : Controller
    {
        private readonly IDanhMucRepository _danhMucRepository;
        public DanhMucController(IDanhMucRepository danhMucRepository)
        {
            _danhMucRepository = danhMucRepository;
        }

        /// <summary>
        /// Create by Tri Minh, Date: 22/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_MoTaLoi))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_MoTaLoi([FromBody] DM_MoTaLoi_ViewModel model)
        {
            var result = new CustomJsonResult();
            var lst = _danhMucRepository.DM_MoTaLoi(model);
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
        /// Create by Tri Minh, Date: 23/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_ChungLoai))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_ChungLoai([FromBody] DM_ChungLoaiHang_ViewModel model)
        {
            var result = new CustomJsonResult();
            var lst = _danhMucRepository.DM_ChungLoai(model);
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
        /// Create by Tri Minh, Date: 24/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_CuaHang))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_CuaHang([FromBody] DM_CuaHang_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _danhMucRepository.DM_CuaHang(model);
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
        /// Create by Tri Minh, Date: 24/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_LoaiThuChi))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_LoaiThuChi([FromBody] DM_LoaiThuChi_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _danhMucRepository.DM_LoaiThuChi(model);
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
        /// Create by Tri Minh, Date: 03/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_CaLamViec))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_CaLamViec([FromBody] DM_CaLamViec_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _danhMucRepository.DM_CaLamViec(model);
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
        /// Create by Tri Minh, Date: 07/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_ThuHoi_DinhMuc))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_ThuHoi_DinhMuc([FromBody] DM_LenhThuHoi_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _danhMucRepository.DM_ThuHoi_DinhMuc(model);
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
        /// Create by Tri Minh, Date: 07/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_BaoHanh))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_BaoHanh([FromBody] DM_ThoiGianBaoHanh_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _danhMucRepository.DM_BaoHanh(model);
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
        /// Create by Tri Minh, Date: 07/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_VungMien))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_VungMien([FromBody] DM_VungMien_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _danhMucRepository.DM_VungMien(model);
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
        /// Create by Tri Minh, Date: 08/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_Size))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_Size([FromBody] DM_Size_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _danhMucRepository.DM_Size(model);
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
        [HttpPost(Name = nameof(DM_LoaiHang))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_LoaiHang([FromBody] DM_LoaiHang_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _danhMucRepository.DM_LoaiHang(model);
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
        [HttpPost(Name = nameof(DM_DonViTinh))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_DonViTinh([FromBody] DM_DonViTinh_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _danhMucRepository.DM_DonViTinh(model);
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
        /// Create by Tri Minh, Date: 24/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_PhanLoai))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_PhanLoai([FromBody] DM_PhanLoai_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _danhMucRepository.DM_PhanLoai(model);
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
        /// Create by Tri Minh, Date: 25/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_ThuongHieu))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_ThuongHieu([FromBody] DM_ThuongHieu_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _danhMucRepository.DM_ThuongHieu(model);
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
        /// Create by Tri Minh, Date: 21/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_DongSanPham))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_DongSanPham([FromBody] DM_DongSanPham_ViewModel model)
        {
            var result = new CustomJsonResult();
            try
            {
                var lst = _danhMucRepository.DM_DongSanPham(model);
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
        /// Create by Duy Tan, Date: 11/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_PhanKhu))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_PhanKhu([FromBody] DM_PhanKhu_ViewModel model)
        {
            var result = new CustomJsonResult();

            var lst = _danhMucRepository.DM_PhanKhu(model);
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
        /// Create by Duy Tan, Date: 11/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_Khu))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_Khu([FromBody] DM_Khu_ViewModel model)
        {
            var result = new CustomJsonResult();

            var lst = _danhMucRepository.DM_Khu(model);
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
        /// Create by Duy Tan, Date: 11/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_LoaiKhachHang))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_LoaiKhachHang([FromBody] DM_LoaiKhachHang_ViewModel model)
        {
            var result = new CustomJsonResult();

            var lst = _danhMucRepository.DM_LoaiKhachHang(model);
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
        /// Create by Duy Tan, Date: 11/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_SuKien))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_SuKien([FromBody] DM_SuKien_ViewModel model)
        {
            var result = new CustomJsonResult();

            var lst = _danhMucRepository.DM_SuKien(model);
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
        /// Create by Duy Tan, Date: 11/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost(Name = nameof(DM_NhomGia))]
        [Produces(typeof(CustomJsonResult))]
        public ActionResult DM_NhomGia([FromBody] DM_NhomGia_ViewModel model)
        {
            var result = new CustomJsonResult();

            var lst = _danhMucRepository.DM_NhomGia(model);
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

    }

}
