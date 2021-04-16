using System.Collections.Generic;
using VNG.Business.Entities.CuaHang;
using VNG.Business.Models.CuaHang;

namespace API_VNG.Repository.BanHang
{
    public interface IBanHangRepository
    {
        /// <summary>
        /// Create by Tri Minh, Date: 24/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CH_BanHang> CH_BanHang(CH_BanHang_ViewModel model);
        /// <summary>
        /// Create by Tri Minh, Date: 13/08/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CH_DoiTraHang> CH_DoiTraHang(CH_DoiTraHang_ViewModel model);


        /// <summary>
        /// Create by Tri Minh, Date: 28/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CH_BaoCaoKetCa> CH_BaoCaoKetCa(CH_BaoCaoKetCa_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 23/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CH_GiaySua> CH_GiaySua(CH_GiaySua_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 18/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CH_ChiTietGiaySua> CH_ChiTietGiaySua(CH_ChiTietGiaySua_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 18/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CH_DatHangNoiBo> CH_DatHangNoiBo(CH_DatHangNoiBo_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 19/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CH_ChiTietDatHangNoiBo> CH_ChiTietDatHangNoiBo(CH_ChiTietDatHangNoiBo_ViewModel model);

        List<CH_GiayDat> CH_GiayDat(CH_GiayDat_ViewModel model);

        List<CH_GiayDatChiTiet> CH_GiayDatChiTiet(CH_GiayDatChiTiet_ViewModel model);

        List<CH_ChiTietPhieuTang> CH_ChiTietPhieuTang(CH_ChiTietPhieuTang_ViewModel model);

        List<CH_PhieuTang> CH_PhieuTang(CH_PhieuTang_ViewModel model);

        /// <summary>
        /// Create by Trí Minh, Date: 23/02/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CH_GiaBan> CH_GiaBan(CH_GiaBan_ViewModel model);
    }
}