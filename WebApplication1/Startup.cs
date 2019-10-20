using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connetion = Configuration.GetConnectionString("Identitydb");
            services.AddDbContext<ApplicationDataContext>(options =>
               options.UseSqlServer(connetion)
            );

            services.AddIdentity<ApplicationUser, IdentityRole<Guid>>()
                .AddEntityFrameworkStores<ApplicationDataContext>()
                .AddDefaultTokenProviders();

            //autenticacao externas
            services.AddAuthentication().AddFacebook(facebookOptions =>
                {
                    facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                    facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];

                    facebookOptions.Scope.Add("user_birthday");

                    facebookOptions.ClaimActions.MapJsonKey(ClaimTypes.Locality, "locale");

                    facebookOptions.SaveTokens = true;
                })
                .AddGoogle(googleOptions =>
                {
                    googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];

                    googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];

                    googleOptions.SaveTokens = true;
                }).
                AddTwitter(twitterOptions =>
                {
                    twitterOptions.ConsumerKey = Configuration["Authentication:Twitter:ConsumerKey"];
                    twitterOptions.ConsumerSecret = Configuration["Authentication:Twitter:ConsumerSecret"];

                    twitterOptions.SaveTokens = true;

                    twitterOptions.RetrieveUserDetails = true;

                    twitterOptions.ClaimActions.MapJsonKey(ClaimTypes.Email, "email", ClaimValueTypes.Email);
                })
                .AddMicrosoftAccount(maoptions =>
                {
                    maoptions.ClientId = Configuration["Authentication:Microsoft:ClientId"];
                    maoptions.ClientSecret = Configuration["Authentication:Microsoft:ClientSecret"];

                    maoptions.SaveTokens = true;
                })
                .AddLinkedIn(linkedinOptions =>
                {
                    linkedinOptions.ClientId = Configuration["Authentication:Linkedin:ClientId"];
                    linkedinOptions.ClientSecret = Configuration["Authentication:Linkedin:ClientSecret"];

                    linkedinOptions.SaveTokens = true;
                });

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            // configuracao padrao
            //configuracao e projeto da aula do curso  https://app.balta.io/player/1977/modules/2/classes/7
            //================================================
            //services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            //    {
            //        //bloqueia o acesso do usuario apos uma certa tentativas 
            //        //determina se o novo usuario podera ser bloqueado ou nao
            //        options.Lockout.AllowedForNewUsers = true;
            //        //determina a quantidade de tempo ao qual um usuario devera ser bloqueado quando ocorrer algum bloqueio
            //        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            //        //determina o numero de tentativas de acesso com falha ate o usuario ser bloqueado se o lockout tiver ativo
            //        options.Lockout.MaxFailedAccessAttempts = 5;
            //    });
            //=========================================================


            services.Configure<IdentityOptions>(options =>
            {
                //define a configuracao do password do sistema
                //determina a obrigatoriedade de um numero de 0-9  na senha 
                //options.Password.RequireDigit = true;
                //determina o tamanho minimmo de caracteres aceitavel
                // options.Password.RequiredLength = 6;
                //compativel apenas com o aspnetcore 2 ou posterior determina a quantidade minima de caracteres diferentes na senha
                //options.Password.RequiredUniqueChars = 1;
                //determina se e obrigatorio ter uma letra minuscula na senha
                //options.Password.RequireLowercase = true;
                //determina se e obrigatorio ter uma letra maiuscula
                // options.Password.RequireUppercase = true;
                //determina se precisa de algum caracteres a mais que nao seje numeros ou letras
                //options.Password.RequireNonAlphanumeric = true;
                //================================================================


                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;//valor padrao 6
                options.Password.RequiredUniqueChars = 6; //valor padrao 1
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;

                //=================================================================

                //define as configuracao de signin
                //determina que para o usuario entrar no sistema ele deve ter o email confirmado
                //options.SignIn.RequireConfirmedEmail = false;
                //determina se para o usuario usar o sistema ele devera ter confirmado um numero de telefone
                //options.SignIn.RequireConfirmedPhoneNumber = false;

                //============================================================================================
                //define as configuracao do token
                //define ou obtem o AuthenticatorTokenProvider e utilizado para validar ou gerar valores
                //options.Tokens.AuthenticatorTokenProvider
                //define ou obtem o ChangeEmailTokenProvider para gerar token utilizado no e-mail de confirmacao no processo de alteracao de e-mail do usuario
                // options.Tokens.ChangeEmailTokenProvider
                //define ou obtem ChangePhoneNumberTokenProvider usado para gerar token utilizado no para alteracao de numero de telefone do usuario
                //options.Tokens.ChangePhoneNumberTokenProvider
                //define o EmailConfirmationTokenProvider usado para gerar token utilizado na confirmacao de e-mail configurado pelo usuario
                //options.Tokens.EmailConfirmationTokenProvider
                //define o obtem PasswordResetTokenProvider usado para gerar token utilizado no processo de alteracao da senha
                //options.Tokens.PasswordResetTokenProvider

                //==============================================================================================

                //configuracao de criacao de usuarios
                //define os caracteres permitidos para o nome do usuario
                //options.User.AllowedUserNameCharacters =
                   // "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+"; //pode ser adicionado caracteres a mais
                   //determina se cada usuario pode ter um e-mail unico ou nao
                  //options.User.RequireUniqueEmail = false;
                  //===========================================================================================================
            });

            services.ConfigureApplicationCookie(options =>
            {
                //configuracao de cookie
                //define o caminho para o hendler responsavel para tratar o erro 403 redirecionando para o caminho configurado
                //options.AccessDeniedPath = "/Account/AccessDenied";
                //segue o mesmo padrao da opicao de token que sera utilizado para criacao de qualquer claims
                //options.ClaimsIssuer = "";
                //define o dominio que o cookie que sera criado pertence
                //options.Cookie.Domain = "";
                //define o tempo de vida do http o cookie http nao e o cookie de altenticacao ela e sobresquita pelo  options.ExpireTimeSpan nao deve ser usado no contexto de cookie altenticator
                //options.Cookie.Expiration = "";
                //endica se o cookie pode ou nao ser acessado pelo cliente sider e todo cookie gerado pode ser acessado pelo cliente sider
                //options.Cookie.HttpOnly = true;
                //nome do cookie
                //options.Cookie.Name = "AspNetCore.Cookies";
                //determina o caminho do cookie
                //options.Cookie.Path = "";
                //define o atributo samesite
                //options.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax;
                //define as configuracoes de Cookie SecurePolicy
                //options.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest;
                //define o componente que sera utilizado para obter os cookies do request ou defini os cookies dos response deve ser fazer classe que faça a implementacao do ICookieManager
                //options.CookieManager =
                //tambem necessita de uma classe que implemente a interface IDataProtectionProvider 
                //options.DataProtectionProvider
                //manipulador responsavel por chama os metodos do provider que dara controle a aplicacao em certos pontos onde ocorre processamentos
                //options.Events =
                //options.EventsType =
                //controla quanto tempo o tickete de autenticacao armazenado no cookie permenecera valido a partir do momento que foi criado
                //options.ExpireTimeSpan = TimeSpan.FromDays(14);
                //define o caminho onde o login deve ser realizado
                //options.LoginPath = "/Account/Login";
                //caminho ao qual o usuario sera direcionado para realizar o processo de logout
                //options.LogoutPath = "/Account/Logout";
                //nome da variavel que recebera a url que o usuario sera redirecionado apos realizar o login
                //options.ReturnUrlParameter = "ReturnUrl";
                //define o conteiner opicional a qual armazenara a indentidade do usuario durante as requisicoes
                //options.SessionStore = "";
                //um novo cookies sera criado quando o cookie atual tera chegado na metade do tempo de expiracao
                //options.SlidingExpiration  = true;
                //usado para proteger e desproteger a indentidade e outras propiedades armazenadas no valor do cookie
                //options.TicketDataFormat = 
                //==================================================================================================



                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.AddControllersWithViews();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
