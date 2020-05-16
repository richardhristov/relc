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
                new Login(3, "180321001", "180321001", LoginType.Student, "Тони", "Бекирски"),
                new Login(4, "180321002", "180321002", LoginType.Student, "Георги", "Желязков"),
                new Login(5, "180321003", "180321003", LoginType.Student, "Иоан", "Аврамов"),
                new Login(6, "180321004", "180321004", LoginType.Student, "Мария", "Павлова"),
                new Login(7, "180321005", "180321005", LoginType.Student, "Мартин", "Господинов"),
                new Login(8, "180321006", "180321006", LoginType.Student, "Невена", "Мандева"),
                new Login(9, "180321007", "180321007", LoginType.Student, "Невелина", "Аладжова"),
                new Login(10, "180321008", "180321008", LoginType.Student, "Стефан", "Кючуков"),
                new Login(11, "180321009", "180321009", LoginType.Student, "Румен", "Димов"),
                new Login(12, "180321010", "180321010", LoginType.Student, "Теодора", "Пачелийска"),
                new Login(13, "180321011", "180321011", LoginType.Student, "Емилия", "Назърова"),
                new Login(14, "180321012", "180321012", LoginType.Student, "Веселин", "Станчев"),
                new Login(15, "180321014", "180321014", LoginType.Student, "Иван", "Иванов"),
                new Login(16, "180321015", "180321015", LoginType.Student, "Кирил", "Караколев"),
                new Login(17, "180321016", "180321016", LoginType.Student, "Маноела", "Неделчева"),
                new Login(18, "180321017", "180321017", LoginType.Student, "Айгюл", "Аптурахим"),
                new Login(19, "180321018", "180321018", LoginType.Student, "Камен", "Трайков"),
                new Login(20, "180321019", "180321019", LoginType.Student, "Румяна", "Мурлева"),
                new Login(21, "180321020", "180321020", LoginType.Student, "Антоан", "Майдозян"),
                new Login(22, "180321021", "180321021", LoginType.Student, "Велислав", "Андонов"),
                new Login(23, "180321022", "180321022", LoginType.Student, "Йордан", "Данчев"),
                new Login(24, "180321023", "180321023", LoginType.Student, "Богдан", "Икимов"),
                new Login(25, "180321024", "180321024", LoginType.Student, "Мартин", "Василев"),
                new Login(26, "180321025", "180321025", LoginType.Student, "Ирина", "Циркалова"),
                new Login(27, "180321026", "180321026", LoginType.Student, "Никола", "Сидеров"),
                new Login(28, "180321027", "180321027", LoginType.Student, "Елиан", "Тодоров"),
                new Login(29, "180321028", "180321028", LoginType.Student, "Росен", "Рунтев"),
                new Login(30, "180321029", "180321029", LoginType.Student, "Надежда", "Георгиева"),
                new Login(31, "180321030", "180321030", LoginType.Student, "Петър", "Узунов"),
                new Login(32, "180321031", "180321031", LoginType.Student, "Петър", "Маламов"),
                new Login(33, "180321032", "180321032", LoginType.Student, "Даниел", "Леви"),
                new Login(34, "180321033", "180321033", LoginType.Student, "Сабри", "Юмер"),
                new Login(35, "180321034", "180321034", LoginType.Student, "Бедреттин", "Бекир"),
                new Login(36, "180321035", "180321035", LoginType.Student, "Теодор", "Боянов"),
                new Login(37, "180321036", "180321036", LoginType.Student, "Димитрия", "Христева"),
                new Login(38, "180321037", "180321037", LoginType.Student, "Тони", "Момчилова"),
                new Login(39, "180321038", "180321038", LoginType.Student, "Георги", "Бютюнев"),
                new Login(40, "180321039", "180321039", LoginType.Student, "Илияна", "Савова"),
                new Login(41, "180321040", "180321040", LoginType.Student, "Калин", "Йержабек"),
                new Login(42, "180321041", "180321041", LoginType.Student, "Бурджу", "Бахри"),
                new Login(43, "180321042", "180321042", LoginType.Student, "Емил", "Пеев"),
                new Login(44, "180321043", "180321043", LoginType.Student, "Иванина", "Иванова"),
                new Login(45, "180321044", "180321044", LoginType.Student, "Диян", "Недков"),
                new Login(46, "180321045", "180321045", LoginType.Student, "Едис", "Хаджи"),
                new Login(47, "180321046", "180321046", LoginType.Student, "Йоан", "Караманов"),
                new Login(48, "180321047", "180321047", LoginType.Student, "Велизар", "Велев"),
                new Login(49, "180321048", "180321048", LoginType.Student, "Джан", "Махмуд"),
                new Login(50, "180321049", "180321049", LoginType.Student, "Марияна", "Бояджиева"),
                new Login(51, "180321050", "180321050", LoginType.Student, "Никола", "Георгиев"),
                new Login(52, "180321051", "180321051", LoginType.Student, "Николай", "Мурджев"),
                new Login(53, "180321052", "180321052", LoginType.Student, "Андрий", "Ряпов"),
                new Login(54, "180321053", "180321053", LoginType.Student, "Вейсел", "Русков"),
                new Login(55, "180321054", "180321054", LoginType.Student, "Габриела", "Михайлова"),
                new Login(56, "180321055", "180321055", LoginType.Student, "Георги", "Георгиев"),
                new Login(57, "180321056", "180321056", LoginType.Student, "Антони", "Ангелов"),
                new Login(58, "180321057", "180321057", LoginType.Student, "Щилян", "Казаков"),
                new Login(59, "180321058", "180321058", LoginType.Student, "Петър", "Парушев"),
                new Login(60, "180321059", "180321059", LoginType.Student, "Михаела", "Кратунова"),
                new Login(61, "180321060", "180321060", LoginType.Student, "Спасимир", "Тричков"),
                new Login(62, "180321061", "180321061", LoginType.Student, "Михаела", "Цачева"),
                new Login(63, "180321062", "180321062", LoginType.Student, "Екрем", "Дрянов"),
                new Login(64, "180321063", "180321063", LoginType.Student, "Ричард", "Христов"),
                new Login(65, "180321064", "180321064", LoginType.Student, "Дейвид", "Коуди"),
                new Login(66, "180321065", "180321065", LoginType.Student, "Дарен", "Стоев"),
                new Login(67, "180321066", "180321066", LoginType.Student, "Йосиф", "Йозов"),
                new Login(68, "180321067", "180321067", LoginType.Student, "Йордан", "Кондаков"),
                new Login(69, "180321068", "180321068", LoginType.Student, "Бианка", "Минева"),
                new Login(70, "180321069", "180321069", LoginType.Student, "Георги", "Найдев"),
                new Login(71, "180321070", "180321070", LoginType.Student, "Атанас", "Найдев"),
                new Login(72, "180321071", "180321071", LoginType.Student, "Теодор", "Пейчев"),
                new Login(73, "180321072", "180321072", LoginType.Student, "Петър", "Ангелов"),
                new Login(74, "180321073", "180321073", LoginType.Student, "Атанас", "Янев"),
                new Login(75, "180321074", "180321074", LoginType.Student, "Радостин", "Господинов"),
                new Login(76, "180321075", "180321075", LoginType.Student, "Теодора", "Младенова"),
                new Login(77, "180321076", "180321076", LoginType.Student, "Величка", "Стоянова"),
                new Login(78, "180321077", "180321077", LoginType.Student, "Лъчезар", "Митев"),
                new Login(79, "180321078", "180321078", LoginType.Student, "Илияна", "Ангелова"),
                new Login(80, "180321079", "180321079", LoginType.Student, "Хари", "Балабанов"),
                new Login(81, "180321080", "180321080", LoginType.Student, "Незиха", "Хаджиева"),
                new Login(82, "180321081", "180321081", LoginType.Student, "Николай", "Недялков"),
                new Login(83, "180321082", "180321082", LoginType.Student, "Костадин", "Запрянов"),
                new Login(84, "180321083", "180321083", LoginType.Student, "Габриел", "Гигов"),
                new Login(85, "180321084", "180321084", LoginType.Student, "Георги", "Георгиев"),
                new Login(86, "180321086", "180321086", LoginType.Student, "Димитър", "Илиев"),
                new Login(87, "180321087", "180321087", LoginType.Student, "Кристиян", "Димов"),
                new Login(88, "180321088", "180321088", LoginType.Student, "Николай", "Кръстев"),
                new Login(89, "180321089", "180321089", LoginType.Student, "Димитър", "Тодоров"),
                new Login(90, "180321090", "180321090", LoginType.Student, "Виктор", "Хаджиев"),
                new Login(91, "180321091", "180321091", LoginType.Student, "Дилян", "Янков"),
                new Login(92, "180321092", "180321092", LoginType.Student, "Алекс", "Манолов"),
                new Login(93, "180321093", "180321093", LoginType.Student, "Ивелин", "Танев"),
                new Login(94, "180321094", "180321094", LoginType.Student, "Валерий", "Шулика"),
                new Login(95, "180321095", "180321095", LoginType.Student, "Богдан", "Ихтияров"),
                new Login(96, "180321096", "180321096", LoginType.Student, "Валентин", "Ихтияров"),
                new Login(97, "180321097", "180321097", LoginType.Student, "Димитър", "Костов"),
                new Login(98, "180321098", "180321098", LoginType.Student, "Владислав", "Владов"),
                new Login(99, "180321099", "180321099", LoginType.Student, "Сергий", "Георгиев"),
                new Login(100, "1803261100", "1803261100", LoginType.Student, "Артем", "Георгиев"),
                new Login(101, "1803261101", "1803261101", LoginType.Student, "Дмитро", "Добрев"),
                new Login(102, "1803261102", "1803261102", LoginType.Student, "Кирило", "Безниско"),
                new Login(103, "1803261104", "1803261104", LoginType.Student, "Сергий", "Биков"),
                new Login(104, "1803261105", "1803261105", LoginType.Student, "Илля", "Кирилив"),
                new Login(105, "1803261106", "1803261106", LoginType.Student, "Сергий", "Сакали"),
                new Login(106, "1803261108", "1803261108", LoginType.Student, "Денис", "Репев"),
                new Login(107, "nikiv", "nikipass", LoginType.Teacher, "Николай", "Вълчанов")
            );
        }
    }
}
