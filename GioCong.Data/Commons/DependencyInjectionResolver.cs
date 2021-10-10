using GioCong.Data.Models;
using Microsoft.Extensions.DependencyInjection;
using GioCong.Data.Services;
using GioCong.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GioCong.Data.Commons
{
    public static class DependencyInjectionResolverGen
    {
        public static void InitializerDI(this IServiceCollection services)
        {
            services.AddScoped<DbContext, GioCongContext>();
        
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAccountRepository, AccountRepository>();
        
            services.AddScoped<IAdvancedPaymentService, AdvancedPaymentService>();
            services.AddScoped<IAdvancedPaymentRepository, AdvancedPaymentRepository>();
        
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
        
            services.AddScoped<ICompetitionService, CompetitionService>();
            services.AddScoped<ICompetitionRepository, CompetitionRepository>();
        
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        
            services.AddScoped<IEmployeeDepartmentService, EmployeeDepartmentService>();
            services.AddScoped<IEmployeeDepartmentRepository, EmployeeDepartmentRepository>();
        
            services.AddScoped<IPayAdvancedService, PayAdvancedService>();
            services.AddScoped<IPayAdvancedRepository, PayAdvancedRepository>();
        
            services.AddScoped<IPayPeriodService, PayPeriodService>();
            services.AddScoped<IPayPeriodRepository, PayPeriodRepository>();
        
            services.AddScoped<IPayScheduleService, PayScheduleService>();
            services.AddScoped<IPayScheduleRepository, PayScheduleRepository>();
        
            services.AddScoped<IPayslipService, PayslipService>();
            services.AddScoped<IPayslipRepository, PayslipRepository>();
        
            services.AddScoped<IPayslipHistoryService, PayslipHistoryService>();
            services.AddScoped<IPayslipHistoryRepository, PayslipHistoryRepository>();
        
            services.AddScoped<IPlanTypeService, PlanTypeService>();
            services.AddScoped<IPlanTypeRepository, PlanTypeRepository>();
        
            services.AddScoped<ISavingItemService, SavingItemService>();
            services.AddScoped<ISavingItemRepository, SavingItemRepository>();
        
            services.AddScoped<ISavingPlanService, SavingPlanService>();
            services.AddScoped<ISavingPlanRepository, SavingPlanRepository>();
        }
    }
}
