using System.Collections.Generic;
using VNG.Business.Entities.System;
using VNG.Business.Models.System;

namespace API_VNG.Repository
{
    public interface IHeThongRepository
    {
        /// <summary>
        /// Create by Tri Minh, Date: 10/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<SYS_Info> ThongTin(SYS_Info_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 19/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<SYS_DB_Log> DB_Log(SYS_DB_Log_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 20/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<SYS_User> NguoiDung(SYS_User_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 21/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<SYS_Setting> ThietLap(SYS_Setting_ViewModel model);

        /// <summary>
        ///  Create by Tri Minh, Date: 22/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<SYS_Permission> PhanQuyen(SYS_Permission_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 22/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<SYS_GroupPermission> NhomPhanQuyen(SYS_GroupPermission_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 06/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<HT_DangKyPhanMem> HT_DangKyPhanMem(HT_DangKyPhanMem_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 06/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<SYS_Tutorial> HT_HuongDan(SYS_Tutorial_ViewModel model);
    }
}
