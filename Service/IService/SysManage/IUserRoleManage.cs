﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    /// <summary>
    /// Service层用户与角色关系接口
    /// add yuangang by 2016-05-19
    /// </summary>
    public interface IUserRoleManage : IRepository<Domain.SYS_USER_ROLE>
    {
        /// <summary>
        /// 设置用户角色
        /// add yuangang by 2016-05-19
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="roleId">角色ID字符串</param>
        /// <returns></returns>
        bool SetUserRole(int userId, string roleId);
    }
}