using System.Collections.Generic;
using VNG.Business.Entities.KhoTong;
using VNG.Business.Entities.Public;
using VNG.Business.Models.KhoTong;
using VNG.Business.Models.Public;

namespace API_VNG.Repository.KhoTong
{
    public interface IKhoTongRepository
    {
        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<NhapKho> KT_NhapKho(NhapKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<XuatKho> KT_XuatKho(XuatKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 28/09/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<KT_VanChuyen> KT_VanChuyen(KT_VanChuyen_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 02/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<KT_TonKho> KT_TonKho(KT_TonKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<NhapKho> KT_TonKhoThung(NhapKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 02/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<KT_YeuCauVungMien> KT_YeuCauTuVungMien(KT_YeuCauVungMien_ViewModel model);


        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<KT_VanChuyen> KT_VanChuyen_HangLoi(KT_VanChuyen_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<NhapKho> KT_NhapLoi(NhapKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 01/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<XuatKho> KT_XuatLoi(XuatKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<KT_TonKho> KT_TonKhoLoi(KT_TonKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<KT_TonKho> KT_TonKhoSale(KT_TonKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 01/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<XuatKho> KT_XuatSale(XuatKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 01/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<NhapKho> KT_NhapSale(NhapKho_ViewModel model);


        /// <summary>
        /// Create by Duy Tan, Date: 31/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<NhapKho> KT_NhapChinhKho(NhapKho_ViewModel model);

        /// <summary>
        /// Create by Duy Tan, Date: 31/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<XuatKho> KT_XuatChinhKho(XuatKho_ViewModel model);

        /// <summary>
        /// Create by Duy Tan, Date: 03/03/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<KT_TonKho_BaoCao> KT_TonKho_BaoCao(KT_TonKho_BaoCao_ViewModel model);
    }
}