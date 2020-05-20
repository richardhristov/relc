using Microsoft.EntityFrameworkCore;
using relc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace relc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<Attempt> Attempts { get; set; }
        public DbSet<AttemptAnswer> AttemptAnswers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Login> Logins { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Login>().HasData(
                new Login(1, "mandingo", "bbc", LoginType.Teacher, "Mandingo", "The Great"),
                new Login(2, "brek", "generics", LoginType.Teacher, "Станимир", "Стоянов"),
                new Login(3, "1801321001", "1801321001", LoginType.Student, "Тони", "Бекирски"),
                new Login(4, "1801321002", "1801321002", LoginType.Student, "Георги", "Желязков"),
                new Login(5, "1801321003", "1801321003", LoginType.Student, "Иоан", "Аврамов"),
                new Login(6, "1801321004", "1801321004", LoginType.Student, "Мария", "Павлова"),
                new Login(7, "1801321005", "1801321005", LoginType.Student, "Мартин", "Господинов"),
                new Login(8, "1801321006", "1801321006", LoginType.Student, "Невена", "Мандева"),
                new Login(9, "1801321007", "1801321007", LoginType.Student, "Невелина", "Аладжова"),
                new Login(10, "1801321008", "1801321008", LoginType.Student, "Стефан", "Кючуков"),
                new Login(11, "1801321009", "1801321009", LoginType.Student, "Румен", "Димов"),
                new Login(12, "1801321010", "1801321010", LoginType.Student, "Теодора", "Пачелийска"),
                new Login(13, "1801321011", "1801321011", LoginType.Student, "Емилия", "Назърова"),
                new Login(14, "1801321012", "1801321012", LoginType.Student, "Веселин", "Станчев"),
                new Login(15, "1801321014", "1801321014", LoginType.Student, "Иван", "Иванов"),
                new Login(16, "1801321015", "1801321015", LoginType.Student, "Кирил", "Караколев"),
                new Login(17, "1801321016", "1801321016", LoginType.Student, "Маноела", "Неделчева"),
                new Login(18, "1801321017", "1801321017", LoginType.Student, "Айгюл", "Аптурахим"),
                new Login(19, "1801321018", "1801321018", LoginType.Student, "Камен", "Трайков"),
                new Login(20, "1801321019", "1801321019", LoginType.Student, "Румяна", "Мурлева"),
                new Login(21, "1801321020", "1801321020", LoginType.Student, "Антоан", "Майдозян"),
                new Login(22, "1801321021", "1801321021", LoginType.Student, "Велислав", "Андонов"),
                new Login(23, "1801321022", "1801321022", LoginType.Student, "Йордан", "Данчев"),
                new Login(24, "1801321023", "1801321023", LoginType.Student, "Богдан", "Икимов"),
                new Login(25, "1801321024", "1801321024", LoginType.Student, "Мартин", "Василев"),
                new Login(26, "1801321025", "1801321025", LoginType.Student, "Ирина", "Циркалова"),
                new Login(27, "1801321026", "1801321026", LoginType.Student, "Никола", "Сидеров"),
                new Login(28, "1801321027", "1801321027", LoginType.Student, "Елиан", "Тодоров"),
                new Login(29, "1801321028", "1801321028", LoginType.Student, "Росен", "Рунтев"),
                new Login(30, "1801321029", "1801321029", LoginType.Student, "Надежда", "Георгиева"),
                new Login(31, "1801321030", "1801321030", LoginType.Student, "Петър", "Узунов"),
                new Login(32, "1801321031", "1801321031", LoginType.Student, "Петър", "Маламов"),
                new Login(33, "1801321032", "1801321032", LoginType.Student, "Даниел", "Леви"),
                new Login(34, "1801321033", "1801321033", LoginType.Student, "Сабри", "Юмер"),
                new Login(35, "1801321034", "1801321034", LoginType.Student, "Бедреттин", "Бекир"),
                new Login(36, "1801321035", "1801321035", LoginType.Student, "Теодор", "Боянов"),
                new Login(37, "1801321036", "1801321036", LoginType.Student, "Димитрия", "Христева"),
                new Login(38, "1801321037", "1801321037", LoginType.Student, "Тони", "Момчилова"),
                new Login(39, "1801321038", "1801321038", LoginType.Student, "Георги", "Бютюнев"),
                new Login(40, "1801321039", "1801321039", LoginType.Student, "Илияна", "Савова"),
                new Login(41, "1801321040", "1801321040", LoginType.Student, "Калин", "Йержабек"),
                new Login(42, "1801321041", "1801321041", LoginType.Student, "Бурджу", "Бахри"),
                new Login(43, "1801321042", "1801321042", LoginType.Student, "Емил", "Пеев"),
                new Login(44, "1801321043", "1801321043", LoginType.Student, "Иванина", "Иванова"),
                new Login(45, "1801321044", "1801321044", LoginType.Student, "Диян", "Недков"),
                new Login(46, "1801321045", "1801321045", LoginType.Student, "Едис", "Хаджи"),
                new Login(47, "1801321046", "1801321046", LoginType.Student, "Йоан", "Караманов"),
                new Login(48, "1801321047", "1801321047", LoginType.Student, "Велизар", "Велев"),
                new Login(49, "1801321048", "1801321048", LoginType.Student, "Джан", "Махмуд"),
                new Login(50, "1801321049", "1801321049", LoginType.Student, "Марияна", "Бояджиева"),
                new Login(51, "1801321050", "1801321050", LoginType.Student, "Никола", "Георгиев"),
                new Login(52, "1801321051", "1801321051", LoginType.Student, "Николай", "Мурджев"),
                new Login(53, "1801321052", "1801321052", LoginType.Student, "Андрий", "Ряпов"),
                new Login(54, "1801321053", "1801321053", LoginType.Student, "Вейсел", "Русков"),
                new Login(55, "1801321054", "1801321054", LoginType.Student, "Габриела", "Михайлова"),
                new Login(56, "1801321055", "1801321055", LoginType.Student, "Георги", "Георгиев"),
                new Login(57, "1801321056", "1801321056", LoginType.Student, "Антони", "Ангелов"),
                new Login(58, "1801321057", "1801321057", LoginType.Student, "Щилян", "Казаков"),
                new Login(59, "1801321058", "1801321058", LoginType.Student, "Петър", "Парушев"),
                new Login(60, "1801321059", "1801321059", LoginType.Student, "Михаела", "Кратунова"),
                new Login(61, "1801321060", "1801321060", LoginType.Student, "Спасимир", "Тричков"),
                new Login(62, "1801321061", "1801321061", LoginType.Student, "Михаела", "Цачева"),
                new Login(63, "1801321062", "1801321062", LoginType.Student, "Екрем", "Дрянов"),
                new Login(64, "1801321063", "1801321063", LoginType.Student, "Ричард", "Христов"),
                new Login(65, "1801321064", "1801321064", LoginType.Student, "Дейвид", "Коуди"),
                new Login(66, "1801321065", "1801321065", LoginType.Student, "Дарен", "Стоев"),
                new Login(67, "1801321066", "1801321066", LoginType.Student, "Йосиф", "Йозов"),
                new Login(68, "1801321067", "1801321067", LoginType.Student, "Йордан", "Кондаков"),
                new Login(69, "1801321068", "1801321068", LoginType.Student, "Бианка", "Минева"),
                new Login(70, "1801321069", "1801321069", LoginType.Student, "Георги", "Найдев"),
                new Login(71, "1801321070", "1801321070", LoginType.Student, "Атанас", "Найдев"),
                new Login(72, "1801321071", "1801321071", LoginType.Student, "Теодор", "Пейчев"),
                new Login(73, "1801321072", "1801321072", LoginType.Student, "Петър", "Ангелов"),
                new Login(74, "1801321073", "1801321073", LoginType.Student, "Атанас", "Янев"),
                new Login(75, "1801321074", "1801321074", LoginType.Student, "Радостин", "Господинов"),
                new Login(76, "1801321075", "1801321075", LoginType.Student, "Теодора", "Младенова"),
                new Login(77, "1801321076", "1801321076", LoginType.Student, "Величка", "Стоянова"),
                new Login(78, "1801321077", "1801321077", LoginType.Student, "Лъчезар", "Митев"),
                new Login(79, "1801321078", "1801321078", LoginType.Student, "Илияна", "Ангелова"),
                new Login(80, "1801321079", "1801321079", LoginType.Student, "Хари", "Балабанов"),
                new Login(81, "1801321080", "1801321080", LoginType.Student, "Незиха", "Хаджиева"),
                new Login(82, "1801321081", "1801321081", LoginType.Student, "Николай", "Недялков"),
                new Login(83, "1801321082", "1801321082", LoginType.Student, "Костадин", "Запрянов"),
                new Login(84, "1801321083", "1801321083", LoginType.Student, "Габриел", "Гигов"),
                new Login(85, "1801321084", "1801321084", LoginType.Student, "Георги", "Георгиев"),
                new Login(86, "1801321086", "1801321086", LoginType.Student, "Димитър", "Илиев"),
                new Login(87, "1801321087", "1801321087", LoginType.Student, "Кристиян", "Димов"),
                new Login(88, "1801321088", "1801321088", LoginType.Student, "Николай", "Кръстев"),
                new Login(89, "1801321089", "1801321089", LoginType.Student, "Димитър", "Тодоров"),
                new Login(90, "1801321090", "1801321090", LoginType.Student, "Виктор", "Хаджиев"),
                new Login(91, "1801321091", "1801321091", LoginType.Student, "Дилян", "Янков"),
                new Login(92, "1801321092", "1801321092", LoginType.Student, "Алекс", "Манолов"),
                new Login(93, "1801321093", "1801321093", LoginType.Student, "Ивелин", "Танев"),
                new Login(94, "1801321094", "1801321094", LoginType.Student, "Валерий", "Шулика"),
                new Login(95, "1801321095", "1801321095", LoginType.Student, "Богдан", "Ихтияров"),
                new Login(96, "1801321096", "1801321096", LoginType.Student, "Валентин", "Ихтияров"),
                new Login(97, "1801321097", "1801321097", LoginType.Student, "Димитър", "Костов"),
                new Login(98, "1801321098", "1801321098", LoginType.Student, "Владислав", "Владов"),
                new Login(99, "1801321099", "1801321099", LoginType.Student, "Сергий", "Георгиев"),
                new Login(107, "nikiv", "nikipass", LoginType.Teacher, "Николай", "Вълчанов")
            );
        }
    }
}
