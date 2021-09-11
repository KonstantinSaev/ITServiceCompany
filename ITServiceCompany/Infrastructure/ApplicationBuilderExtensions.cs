namespace ITServiceCompany.Infrastructure
{
    using ITServiceCompany.Data;
    using ITServiceCompany.Data.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Linq;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(
        this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var services = serviceScope.ServiceProvider;

            MigrateDatabase(services);

           // SeedWorkerServices(services);
            SeedProjects(services);

            return app;
        }

        private static void MigrateDatabase(IServiceProvider services)
        {
            var data = services.GetRequiredService<ITServiceCompanyDbContext>();

            data.Database.Migrate();
        }
        private static void SeedWorkerServices(IServiceProvider services)
        {
            var data = services.GetRequiredService<ITServiceCompanyDbContext>();

            if (data.WorkerServices.Any())
            {
                return;
            }

            data.WorkerServices.AddRange(new[]
            {
                new  WorkerService { Worker = new Worker{ Name = "Алекса Тачев", Description = "Project Manager с над 18 години опит в сферата. Умее да разпределя правилно времето си, а в свободното си време обича да играе футбол.", ImgUrl="~/lib/photos/alexa_final.png"}, Service = new Service{Name = "Разработка на уеб-сайт <br>и мобилно приложение", Description="Богат опит в изработването на уеб сайтове в различни направления - от презентационни страници и онлайн магазини, до изграждането<br /> на персонализирани уеб приложения и поддържането им."} },
                new WorkerService { Worker = new Worker{ Name = "Константин Саев", Description = "Back-end Developer с повече от 15 години опит, който разрешава проблеми и създава иновативни сайтове и приложения. В свободното си време обича да играе волейбол и да кара ски.", ImgUrl="~/lib/photos/kosio_final.png"} ,Service = new Service{Name = "Разработка на уеб-сайт <br>и мобилно приложение", Description="Богат опит в изработването на уеб сайтове в различни направления - от презентационни страници и онлайн магазини, до изграждането<br /> на персонализирани уеб приложения и поддържането им."} },
                new WorkerService { Worker = new Worker{ Name = "Христо Панев", Description = "  Back-end Developer с 10 години опит, кoйто специализира с разработването на софтуер. Неговите хобита са колоезденето и четенето на най-различни книги.", ImgUrl="~/lib/photos/hristo_final.png"} , Service = new Service{Name = "Разработка на уеб-сайт <br>и мобилно приложение", Description="Богат опит в изработването на уеб сайтове в различни направления - от презентационни страници и онлайн магазини, до изграждането<br /> на персонализирани уеб приложения и поддържането им."}},
                new WorkerService { Worker = new Worker{ Name = "Зорница Артинова", Description = "Front-end Developer с редица проекти зад гърба си. Създава модерни и лесно достъпни сайтове и приложения. Обича да рисува и да се разхожда сред природата.", ImgUrl="~/lib/photos/zori_final.png"}, Service = new Service{Name = "Разработка на уеб-сайт <br>и мобилно приложение", Description="Богат опит в изработването на уеб сайтове в различни направления - от презентационни страници и онлайн магазини, до изграждането<br /> на персонализирани уеб приложения и поддържането им."} },
                new WorkerService { Worker = new Worker{ Name = "Иван Наков", Description = " Той е Front-end Developer с над 11 години опит в бранша. Занимава се основно със създаването на иновативни сайтове. Фен е на рали спорта и високите скорости.", ImgUrl="~/lib/photos/ivan_final.png"} , Service = new Service{Name = "Разработка на уеб-сайт <br>и мобилно приложение", Description="Богат опит в изработването на уеб сайтове в различни направления - от презентационни страници и онлайн магазини, до изграждането<br /> на персонализирани уеб приложения и поддържането им."}},
                new WorkerService { Worker = new Worker{ Name = "Стела Вълкова", Description = "Графичен дизайнер с над 15 години опит в тази сфера. Създава както уеб-дизайн, така и графичен. В свободното си време обича да рисува, да чете книги и да се разхожда из природата.", ImgUrl="~/lib/photos/stela_final.png"}, Service = new Service{Name = "Дизайн и мултимедия", Description="Това е лицето на компания ти. За да покрием напълно нуждите на нашите клиенти, освен решения свързани с уеб, предлагаме и изграждане на цялостна корпоративна идентичност."} },
                new WorkerService { Worker = new Worker{ Name = "Ренета Никoлова", Description = "Тя е с над 12 години опит в обработката на видео и снимки. Цели се към създаването на интересно и забавно визуално съдържание. Нейните хобита са рисуването и колоезденето сред природата.", ImgUrl="~/lib/photos/reni_final.png"}, Service = new Service{Name = "Дизайн и мултимедия", Description="Това е лицето на компания ти. За да покрием напълно нуждите на нашите клиенти, освен решения свързани с уеб, предлагаме и изграждане на цялостна корпоративна идентичност."}  },
                new WorkerService { Worker = new Worker{ Name = "Стоянка Димитрова", Description = "   Marketing Expert с повече от 14 години опит, който разрешава проблеми и създава иновативни решения. В свободното си време обича да чете и рисува.", ImgUrl="~/lib/photos/stoqnka_final.png"}, Service = new Service{Name = "Маркетинговастратегия", Description = "Предлагаме ти планиране, провеждане и мониторинг на рекламни кампании в социалните платформи като Google+, Facebook, Twitter, LinkedIn, YouTube и други." } },
                

            });

            data.SaveChanges();
        }
        private static void SeedProjects(IServiceProvider services)
        {
            var data = services.GetRequiredService<ITServiceCompanyDbContext>();

            if (data.Projects.Any())
            {
                return;
            }

            data.Projects.AddRange(new[]
            {
                new Project { Name = "Община Девин", ImgUrl="https://imgur.com/1g7l0wC.jpg"},
                new Project { Name = "Хотел Исмена", ImgUrl="https://imgur.com/a/9Vnt1i6.jpg"},
                new Project { Name = "Bflow", ImgUrl="https://imgur.com/i9v10kE.jpg"},
                new Project { Name = "Devin AD", ImgUrl="https://imgur.com/2u40Oll.jpg"},
                new Project { Name = "Smule", ImgUrl="https://imgur.com/K6TuhGd.jpg"},
                new Project { Name = "Modis", ImgUrl="https://imgur.com/zZXuzCx.jpg"},

            });

            data.SaveChanges();
        }
    }
}

