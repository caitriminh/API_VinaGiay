using System.Collections.Generic;
using VNG.Business.Entities.Public;
using VNG.Business.Entities.VungMien;
using VNG.Business.Models.Public;
using VNG.Business.Models.VungMien;

namespace API_VNG.Repository.KhoVungMien
{
    public interface IKhoVungMienRepository
    {
        /// <summary>
        ///  Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<NhapKho> VM_NhapKho(NhapKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<XuatKho> VM_XuatKho(XuatKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 30/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<XuatKho> VM_XuatKhoTraKhoTong(XuatKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 31/08/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<VM_TonKho> VM_TonKho(VM_TonKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 29/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<VM_VanChuyen> VM_VanChuyen(VM_VanChuyen_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 30/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<VM_YeuCauCuaHang> VM_VungMienXuatCuaHang(VM_YeuCauCuaHang_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<VM_VanChuyen> VM_VanChuyen_HangLoi(VM_VanChuyen_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<XuatKho> VM_XuatLoi(XuatKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<NhapKho> VM_NhapLoi(NhapKho_ViewModel model);

        /// <summary>
        /// Create by Duy Tan, Date: 31/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<NhapKho> VM_NhapChinhKho(NhapKho_ViewModel model);

        /// <summary>
        /// Create by Duy Tan, Date: 31/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<XuatKho> VM_XuatChinhKho(XuatKho_ViewModel model);

        /// <summary>
        /// Create by Duy Tan, Date: 03/03/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<VM_TonKho_BaoCao> VM_TonKho_BaoCao(VM_TonKho_BaoCao_ViewModel model);

        /// <summary>
        /// Create by Duy Tan, Date: 08/03/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<VM_DinhMuc_BaoCao> VM_DinhMuc_BaoCao(VM_DinhMuc_BaoCao_ViewModel model);
    }
}