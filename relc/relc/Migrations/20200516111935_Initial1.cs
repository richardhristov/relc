using Microsoft.EntityFrameworkCore.Migrations;

namespace relc.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Logins",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(60) CHARACTER SET utf8mb4",
                oldMaxLength: 60);

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "NameFirst", "NameLast", "Password", "Type", "Username" },
                values: new object[,]
                {
                    { 1, "Mandingo", "The Great", "AQAAAAEAACcQAAAAEMB3dHqKD+OSbkkRDi85C9klMy4Q2uAZHGuW12rj8i8kRjNsFreVahofpYFsMlsRFg==", 1, "mandingo" },
                    { 78, "Лъчезар", "Митев", "AQAAAAEAACcQAAAAEG6/OeSBxNHSmOc+PjvcIhan859cg0a1DsAJDGFwcdEq6D2ISZPLT/ufURwhcaIGFg==", 2, "1803261077" },
                    { 77, "Величка", "Стоянова", "AQAAAAEAACcQAAAAEMtq/Gl+/XZ/w1pmQSEjxBf2MS/Gr4PwZmsp2j/Y1uzhgo0FM7jyV35CcleGL30g6w==", 2, "1803261076" },
                    { 76, "Теодора", "Младенова", "AQAAAAEAACcQAAAAEHGswf91Hpp76FV5DE8fdtJDWU4HRYt+3aUd6zVdDXNE+KD/056MCJaos8oUlWV7ew==", 2, "1803261075" },
                    { 75, "Радостин", "Господинов", "AQAAAAEAACcQAAAAEGNd174SNcCydVmfB0hwxBcT0fwuLncsWHN12FKKkHzhVdqT9TMg9YVhufF0n177WQ==", 2, "1803261074" },
                    { 74, "Атанас", "Янев", "AQAAAAEAACcQAAAAEOmrCZa2W7MFHxRtDiP0gm51sv3J3N1il9XmYWpLiDzIo3/5ky7x1Fp2aav/Fw9gZA==", 2, "1803261073" },
                    { 73, "Петър", "Ангелов", "AQAAAAEAACcQAAAAEP9/5nwHLwGR2QyPFEg3VpTekzFi+Sj/3fm3QXxUVW9kiGewhxoRyhCBvmFK4TfV6w==", 2, "1803261072" },
                    { 72, "Теодор", "Пейчев", "AQAAAAEAACcQAAAAEK8kDXKUzvKEtGLeD5JUD1/YlSsCLdMqh6mFR2boXGsswmz5nzE9FMuvSvTjA6omPA==", 2, "1803261071" },
                    { 71, "Атанас", "Найдев", "AQAAAAEAACcQAAAAEApdKgWDaKmOoWGJjJVSnRqTuYIszmOmePjBhCOS+6XsA+Zv5yt03JqaExTrsVtSWg==", 2, "1803261070" },
                    { 70, "Георги", "Найдев", "AQAAAAEAACcQAAAAEEM3mmEdlWh2jaCGygqGqYV3AdmPlkla7iqI7ey0CFO5x9s0wE5fA33LL/I6OjQQSg==", 2, "1803261069" },
                    { 69, "Бианка", "Минева", "AQAAAAEAACcQAAAAELTKd87nUSXAUMyunJCD0ng9Y3yY++VANbPLnghqRmmkvSvd+xuYA5j5m7fVwWrYKw==", 2, "1803261068" },
                    { 68, "Йордан", "Кондаков", "AQAAAAEAACcQAAAAEOTVtVyRPAY03b43qy95kX/Kv4uzjl4HmL3IHxDZRpgcCxSuPOKrHzTpNKuXAgBblA==", 2, "1803261067" },
                    { 67, "Йосиф", "Йозов", "AQAAAAEAACcQAAAAECgrw2iQIbERiyzRnaH6A1vEB6uYaZBjXkeyIjE43UtMIa0/OMFsezYioOKS2bPxkQ==", 2, "1803261066" },
                    { 66, "Дарен", "Стоев", "AQAAAAEAACcQAAAAEG1suWVjbtV9+zf1MHbhf37PHKnOmIoyJvufrd+d1pRLh5UJJcKN1Yl327P5xMAGXA==", 2, "1803261065" },
                    { 65, "Дейвид", "Коуди", "AQAAAAEAACcQAAAAEHwPbEBBLWem71H22JwP2d33aBxBk4S8tckZg2PYo7lAUBArG1nfLEzVUfNjBFlwMA==", 2, "1803261064" },
                    { 64, "Ричард", "Христов", "AQAAAAEAACcQAAAAEGZfJtPmDNhc7QElTMDxYgRL46cGQ58y9gLdjIw1dNlOQiATh2tmysp3EhvYf8TVlQ==", 2, "1803261063" },
                    { 63, "Екрем", "Дрянов", "AQAAAAEAACcQAAAAEJDTRrpFR4pR7QhlLZJ/yLTDVOxKF7rRy1vOzo/2Xmi/+B2SHosjju9LQNhfPwHDgg==", 2, "1803261062" },
                    { 62, "Михаела", "Цачева", "AQAAAAEAACcQAAAAEFQIoIpFBGgwYjhBj95yhwynKM3C97PNKOaJy8rQQ7BciXBapOEYMqAwcr2fSxiC3g==", 2, "1803261061" },
                    { 61, "Спасимир", "Тричков", "AQAAAAEAACcQAAAAEIGzHJ/+/2gteSfXLBWp3WrslWzf3hwxuUOrEOCQOvEHu/VlpHigNB/QzS8HL4hSbQ==", 2, "1803261060" },
                    { 60, "Михаела", "Кратунова", "AQAAAAEAACcQAAAAEBXLuC/baElCtAtHRKKJcy4024jxfOk/AmzX/BCmWM40ONz4baPJbZ1osTB6aew9sg==", 2, "1803261059" },
                    { 59, "Петър", "Парушев", "AQAAAAEAACcQAAAAEJJACpMeT1wAqnp00ZH3cEE4gl5UrLvg1dI7luAY/9UvsMJTg2x836AV41Yrdabmvw==", 2, "1803261058" },
                    { 58, "Щилян", "Казаков", "AQAAAAEAACcQAAAAEKWLHDuvBlcWxVgYha35uP+YMSCQe+0eXrbWYymND2D4TYjEqJQvv2/xbUjsp303gg==", 2, "1803261057" },
                    { 57, "Антони", "Ангелов", "AQAAAAEAACcQAAAAEP6E3w89M3sVx92MJ1+C1Dp43sXNbPfL0O5bxUMslnOrqsSopjak5HNqfKFh/pT62Q==", 2, "1803261056" },
                    { 56, "Георги", "Георгиев", "AQAAAAEAACcQAAAAEPLrceBhsq1pDb0hisLMmX42NTDHctGIs2vjmpoObCVBA+mVmnxCqCUHZC9eMw4AUw==", 2, "1803261055" },
                    { 79, "Илияна", "Ангелова", "AQAAAAEAACcQAAAAEF06ZiQ5WLye1cEuipOkjH4dYruLtALimRHfOJzbyu/O6lTgGIEKs8AWIatd2NQ7vw==", 2, "1803261078" },
                    { 55, "Габриела", "Михайлова", "AQAAAAEAACcQAAAAEPI/TptWM8QPdB3Nh4aOm5vR1m/FQdpsu1ruHisTiC+L/mpc6tv/XSxXHT5/hCaZig==", 2, "1803261054" },
                    { 80, "Хари", "Балабанов", "AQAAAAEAACcQAAAAEIhUpVP+nE2tCUPdCaDhO74ha+fUhWPVorbwmGleZZuYcL+uX9iA45UFZ2MVhqEXCQ==", 2, "1803261079" },
                    { 82, "Николай", "Недялков", "AQAAAAEAACcQAAAAEJ0MGxZv2ifpRDeteORz2qasvK1O10yXsla6ix4ggqsT8nCngdPlOsIwT9TA0XjDig==", 2, "1803261081" },
                    { 105, "Сергий", "Сакали", "AQAAAAEAACcQAAAAEImZKn4XHjfLJ/8HF2izx6qSJpVC/OcB7FLwv9fwzHnM2CgmsYnoTU0VeZVHoGkRLQ==", 2, "1803261106" },
                    { 104, "Илля", "Кирилив", "AQAAAAEAACcQAAAAEOybqIMYGLWxtIEiCQJSJINkz0dRXH8wak6Nu/cDUUN9Udy1adEnhzQHDoR008D+TQ==", 2, "1803261105" },
                    { 103, "Сергий", "Биков", "AQAAAAEAACcQAAAAEA/Q0cfaV6FbKeqEl6fx8w40m6oXzD9Lzollgsih+nLANXDplO/CEHGay1y+FckoSQ==", 2, "1803261104" },
                    { 102, "Кирило", "Безниско", "AQAAAAEAACcQAAAAEJc7Ebq4k29kBXXezZYsaoFwaTczyQ73hcH/YpvngQfUKY3d18CPL5ZRIFNFXiXkQQ==", 2, "1803261102" },
                    { 101, "Дмитро", "Добрев", "AQAAAAEAACcQAAAAEOWie/cMFYNlwhU2rNm5ZGgXvXp7zudAoKHNaWy1let9dn96ONtUh4s6UShq+hgA/Q==", 2, "1803261101" },
                    { 100, "Артем", "Георгиев", "AQAAAAEAACcQAAAAEICWdm/rB88VzIDBj2KtD22XLIsn+aNz3KrEf58wdoNTGBLiNAqcbckiehWANbO8fg==", 2, "1803261100" },
                    { 99, "Сергий", "Георгиев", "AQAAAAEAACcQAAAAEMmJ82Z37BEBUBWU5n6F4Siiyz3UsNN9/erHTwfZVwH3KmpQ4QT1EIQpugsRmfF6Cw==", 2, "1803261099" },
                    { 98, "Владислав", "Владов", "AQAAAAEAACcQAAAAEMP3t32zuG3i9tC4N6txoVrStABpTHu0TATknUGKDl8OSnXMteB7R+GkHgI96rSQAA==", 2, "1803261098" },
                    { 97, "Димитър", "Костов", "AQAAAAEAACcQAAAAELvyzVj+6OtOdmAUVBoEyvRLSQ4W8KJy8fg9mnU7StpQc13xLdDQ6EOieukI1s6Ulw==", 2, "1803261097" },
                    { 96, "Валентин", "Ихтияров", "AQAAAAEAACcQAAAAENRmoKunr7JiALVh+bZHOf92FxprBd8DID7B5WEREe23J+MPO1Xzor6kkcE4XocaaQ==", 2, "1803261096" },
                    { 95, "Богдан", "Ихтияров", "AQAAAAEAACcQAAAAEFdYTlhEV9sn+Rzq6QKTKXXE1bTvLxd3jle4iz7Zcj0b2KNRMfk5EOyG9Y3sWWeYtA==", 2, "1803261095" },
                    { 94, "Валерий", "Шулика", "AQAAAAEAACcQAAAAEO13k8ik1gueaWI9yg+zoDpAm0FtI7k0nCseDLse9vUJhJm8UBXkn4FgJjtoWmAekg==", 2, "1803261094" },
                    { 93, "Ивелин", "Танев", "AQAAAAEAACcQAAAAEHD0idmLSNVpdBVyGG0i4b1CUKtYNHDl7E4z/qkGuaf2/LzFq05dFncadJccxNnplw==", 2, "1803261093" },
                    { 92, "Алекс", "Манолов", "AQAAAAEAACcQAAAAED2ycpju+hkEvLMDD2UFzDmrjbproPivImrWlLhGOUSDb+7ISWdJFcgi7KiW40JiIA==", 2, "1803261092" },
                    { 91, "Дилян", "Янков", "AQAAAAEAACcQAAAAEKeE7+BH5RFc4Hi71SYRjkBOJIJPX6bNlhf4Vz7BLJBLBG1jTkTmF3g3ZqI4kN3v4A==", 2, "1803261091" },
                    { 90, "Виктор", "Хаджиев", "AQAAAAEAACcQAAAAEG9LOuR8ZjKn6vEwXrhG21jPn2cWrW/c144Eu9rMgpqdKd60oViIIoXW32EkNWsyRQ==", 2, "1803261090" },
                    { 89, "Димитър", "Тодоров", "AQAAAAEAACcQAAAAEEzhZmVRhP/MwR6LTq3mgOlJgJ8fxA0kUfG0QNNKJE9LLwhIlMfNEFZGCtSHzO1ZHQ==", 2, "1803261089" },
                    { 88, "Николай", "Кръстев", "AQAAAAEAACcQAAAAEGJr5uGgzLq70SklMzH+KnK4OjzWaRYLd7x/P5o68Y+CFuLbaz3fk4pNBEWs39E5zQ==", 2, "1803261088" },
                    { 87, "Кристиян", "Димов", "AQAAAAEAACcQAAAAEGa0anB4NDUG++czHXC2fpiAoqqbeDzSrYH5usAER90fFp/tD0DtAYlJnfzhCLiRJQ==", 2, "1803261087" },
                    { 86, "Димитър", "Илиев", "AQAAAAEAACcQAAAAEFJdzSO+5xb53GzZr0i9vQmyUp/nggmB69KJxMeard2ep3T9Eoi01pBkhGphRwpYsw==", 2, "1803261086" },
                    { 85, "Георги", "Георгиев", "AQAAAAEAACcQAAAAEI5uMAts9R/ZpvUh1jkmEQSQ/Fsae++VzbtoyKE5iNyNISjkVOTx4yVFwDcDjzqMIQ==", 2, "1803261084" },
                    { 84, "Габриел", "Гигов", "AQAAAAEAACcQAAAAEA4uKwImkXht7fer0IyZUl0f+JMb3mF05WATA1Z62hzSZUHjf6Q9p2F9OdYrOvHdCQ==", 2, "1803261083" },
                    { 83, "Костадин", "Запрянов", "AQAAAAEAACcQAAAAEMgN0NFIaFDCeFw/cL5pMetfhiAhpKBMf3kfXJIGARxj0Vf2WrxjOZKBaTNVL3PbsQ==", 2, "1803261082" },
                    { 81, "Незиха", "Хаджиева", "AQAAAAEAACcQAAAAEKuHHZoXOe4MxbxV4AkRx4J1UFJeDVfqQgyZOFrQYRiKsjSSQQRotCKzm9dlhaVCTQ==", 2, "1803261080" },
                    { 106, "Денис", "Репев", "AQAAAAEAACcQAAAAEIk2KJVvEuXuK5Y4nSS0pIWMjdwuouKV8RcdaEdPolJh46OG6Xr9NVIaraEFBpjhKg==", 2, "1803261108" },
                    { 54, "Вейсел", "Русков", "AQAAAAEAACcQAAAAEDdSw9pVkQIHRCL5CDqE1liKEYUYA9tGTpWedoO4cLjvkkpsSWYPegTYRZrnLwSYGw==", 2, "1803261053" },
                    { 52, "Николай", "Мурджев", "AQAAAAEAACcQAAAAEBUn3pa6q00OcMCoUfFMtIjrgMZIDmt63eOeAhdK8QJNAvm5NKMWbFC1E4bAvErnvg==", 2, "1803261051" },
                    { 24, "Богдан", "Икимов", "AQAAAAEAACcQAAAAELMuGYggD8vfZLx5KAd0OVI3hX0vDiAIUyLj0n+ktKCrivuK/OaEgbt0BPlK7WzFQA==", 2, "1803261023" },
                    { 23, "Йордан", "Данчев", "AQAAAAEAACcQAAAAEObAvU8sMOpWBbQESqpQ7e0Jo1UDS32K+Jxys+9OXA6dorluauQ9WTKhpzl+Qi3qGA==", 2, "1803261022" },
                    { 22, "Велислав", "Андонов", "AQAAAAEAACcQAAAAEPclHhDJh0GJ2znGIY0tMr4aZq+znt1Cu2iVP9PgBEcM8xdNVViaVBJT3Pv399ngKA==", 2, "1803261021" },
                    { 21, "Антоан", "Майдозян", "AQAAAAEAACcQAAAAEBxrW6SyHNtWD9finV2QdSK29mwX71mJJm4NdLz+hgUg3PgHzvak9Fus9o5d5+d1mg==", 2, "1803261020" },
                    { 20, "Румяна", "Мурлева", "AQAAAAEAACcQAAAAEEUW3dr3Cbne1kkk2lHFxn37zzos6Rs1TX4WLDP7I5Up0LQn4IfrIsJ2OkjVb40FxA==", 2, "1803261019" },
                    { 19, "Камен", "Трайков", "AQAAAAEAACcQAAAAEP8pSWgO/y5eUpLaT4XrgR0oWFQ0M5/Gy6KkptMcIRipnJp3pGsKk6shdpThbAzyow==", 2, "1803261018" },
                    { 18, "Айгюл", "Аптурахим", "AQAAAAEAACcQAAAAEKCXhYVT6VkTA0/qWVCZ8t1kJMueOufpigNMe8EyzBRtHhYGJMZdCzhNFSw9/bPb0w==", 2, "1803261017" },
                    { 17, "Маноела", "Неделчева", "AQAAAAEAACcQAAAAEK4bpLf2+4zQwtehkskIyr8cCKLbezNLaNHRAnbVb7JOkpdPNyxXXecbUciLjaQ0tQ==", 2, "1803261016" },
                    { 16, "Кирил", "Караколев", "AQAAAAEAACcQAAAAEHWCua9rOIp+N0GrcDzGgC90y3zcdLSaSJ5WFpsPCGvS0fFE/J6NH0WdtpFux6L+RQ==", 2, "1803261015" },
                    { 15, "Иван", "Иванов", "AQAAAAEAACcQAAAAECNSpcBbimb4mJUMNXcRoJ5bqBlup7h7YBXcOaBAaxMMxxk7408LgZxo1m/tLB49eQ==", 2, "1803261014" },
                    { 14, "Веселин", "Станчев", "AQAAAAEAACcQAAAAEJllhG/QOl13D/j5+MEp7jnHFDpwy6PrKfxlOlJ40/CLxt2AIVCA8ugYAFfnBKbDdg==", 2, "1803261012" },
                    { 13, "Емилия", "Назърова", "AQAAAAEAACcQAAAAEL9Gkj/LDK180ZdXrvU8HIOrnANgaEl8eKKVKUcE7ZzoTMc9kErTX66BEpHWYraT6w==", 2, "1803261011" },
                    { 12, "Теодора", "Пачелийска", "AQAAAAEAACcQAAAAEIipOrxmqCnYcejEiCZNJ2w5PHSfhubOtUWt8R4imfagKl923llPv/89G5Et6eTY+w==", 2, "1803261010" },
                    { 11, "Румен", "Димов", "AQAAAAEAACcQAAAAEI7+zcwIeTezhu0WNr4NrjJ3nZ8UHbvnbo9yyQhVQJ7T8zaWMxw4emCa5elsCX3jcw==", 2, "1803261009" },
                    { 10, "Стефан", "Кючуков", "AQAAAAEAACcQAAAAELaCpPLJTrXfzkg++SXokxuEFQFLINDNxbhtcr7OkvOLNZhEXV05iDbwmr+gwJ/XTw==", 2, "1803261008" },
                    { 9, "Невелина", "Аладжова", "AQAAAAEAACcQAAAAEMwOJFA/tbctEPBKj+4upiIUfKg/gP1iTWyqQSChaYcerwNbSIdgXeeAQGJqqnvVzQ==", 2, "1803261007" },
                    { 8, "Невена", "Мандева", "AQAAAAEAACcQAAAAEMNR68/+aUptN2MlFDCgGc9preOBVh3swubR8QYS/yi6C9J+ULeoQEouOTqc61cXEg==", 2, "1803261006" },
                    { 7, "Мартин", "Господинов", "AQAAAAEAACcQAAAAEGmiYZRDm05djC+crlEFsjx5Nw9wduxclnxyTJG7drpHqSNZ/iUIQ9iXdmdXXZ60Dg==", 2, "1803261005" },
                    { 6, "Мария", "Павлова", "AQAAAAEAACcQAAAAEPimJV3iG49Zs1jg2j/LJY2KMbUNLgMZG6xeYACuwa2+KDo8v+ATSOf7mwtNwUrrFQ==", 2, "1803261004" },
                    { 5, "Иоан", "Аврамов", "AQAAAAEAACcQAAAAED8Vllwz+FDtVXI7Hvko+9VwW9Es+VOQI9fCKzZQBKvF72mNxV+JSGL6L45ULIhuww==", 2, "1803261003" },
                    { 4, "Георги", "Желязков", "AQAAAAEAACcQAAAAEBqoJ4zUJ3d2xzkWUje8hVhMfUPtZMcEBPhtpx13xT+SEGTmD3mh5+TdUo2ZJADo6A==", 2, "1803261002" },
                    { 3, "Тони", "Бекирски", "AQAAAAEAACcQAAAAEM/yfymPvzU1FA698CqMKz6dX45JiyS584DRbZbvccyt9ACH8Qee7bKr/v0SXb0iTw==", 2, "1803261001" },
                    { 2, "Станимир", "Стоянов", "AQAAAAEAACcQAAAAELG8kUJRWU1Dow9iWbVaWV8XkGfxd4Ett4WohiShBWdIxMyLVaiXpIGPSGZ/6fH9cg==", 1, "brek" },
                    { 25, "Мартин", "Василев", "AQAAAAEAACcQAAAAEEdtjp9AovpQNzKkTSSa9FDv4fLliV+Xa2zhiIwC4aFhv5n2awh9xWCdrgwux94nww==", 2, "1803261024" },
                    { 53, "Андрий", "Ряпов", "AQAAAAEAACcQAAAAEFf9Qiij6MbLap7J59tW27NYZaUy5OX91OLxAH1kVR+WsuMmboC+SmI0LN+qvqfuEw==", 2, "1803261052" },
                    { 26, "Ирина", "Циркалова", "AQAAAAEAACcQAAAAEKHU/ch9C4gBEwEfOoa1nETkssUvsylDczkEYBbv7m4fxrYBfv44CST4h5BP78Prqw==", 2, "1803261025" },
                    { 28, "Елиан", "Тодоров", "AQAAAAEAACcQAAAAENMWImO+Ztj5rzufaVXaaR64Q7sSZRa+U4I6BR4uUvXsKqBIyNp0e4yNnuINfdRIvg==", 2, "1803261027" },
                    { 51, "Никола", "Георгиев", "AQAAAAEAACcQAAAAENo+DnuC1DWl54J7b0f2tSl3RF9l9Y4GA10Kh55V4K7NZy0W8o5lxH6UYiUjGAsG2g==", 2, "1803261050" },
                    { 50, "Марияна", "Бояджиева", "AQAAAAEAACcQAAAAEHf14vOxvH212VZLANkN7ZCVjwA/QKCBhSS0e3rNVgsiNuztNU/gELT2GbNamulwTg==", 2, "1803261049" },
                    { 49, "Джан", "Махмуд", "AQAAAAEAACcQAAAAENe7bAb9w7BPhUe/1dMPbWBRCKmbsP6AGosRbORksAKRveH9e12vPtZgCWScKO2ZDA==", 2, "1803261048" },
                    { 48, "Велизар", "Велев", "AQAAAAEAACcQAAAAECeCzqxTk6wsTzXKlkf+zie1fB4vGca+4+d1MMFluyLKD3biOkkLDe3sTa+gT8abYw==", 2, "1803261047" },
                    { 47, "Йоан", "Караманов", "AQAAAAEAACcQAAAAEFeOLKSmcqdvT5S+5088+4jKZox+AK0nr6mRFOBNBFZmDpCD4CHViMghB2iT8biX3w==", 2, "1803261046" },
                    { 46, "Едис", "Хаджи", "AQAAAAEAACcQAAAAEII24cKjJjdip1UZiZ/tvf5sQ2BI+KMHMzNS3b/1XoEru5E/S7hHGIGWmWAc6IT1Hw==", 2, "1803261045" },
                    { 45, "Диян", "Недков", "AQAAAAEAACcQAAAAEPtkLiYU26xSDdeQJy7cfNoD+I1tg3incAWsHPWnfhR3D7wsNriO3n3f5vgOah9XZQ==", 2, "1803261044" },
                    { 44, "Иванина", "Иванова", "AQAAAAEAACcQAAAAEB7uoqoN7W8IrkUhNEPx7gVnc90/ZaIFtvl55eh5ryGpVf8niYRnMJKfn+LrNED9oA==", 2, "1803261043" },
                    { 43, "Емил", "Пеев", "AQAAAAEAACcQAAAAEL9YpnOlHLArodYqpUlbufrkrf57pofac7SytmgHAh9209IYTWj4t7qFihkfM4Yp6A==", 2, "1803261042" },
                    { 42, "Бурджу", "Бахри", "AQAAAAEAACcQAAAAEDZ0/BFOKI9NnBpSYN4qdzKvhAvDJ2rDknOSvBQyG+k1VmxDfBMC8uD8ShLzRFmK8A==", 2, "1803261041" },
                    { 41, "Калин", "Йержабек", "AQAAAAEAACcQAAAAECaN5UUFmTovoFjGBV74AXGge2dZrpqY373Jq5o9or16bpwwusIlembV8x9rurDomA==", 2, "1803261040" },
                    { 40, "Илияна", "Савова", "AQAAAAEAACcQAAAAEE87H0EG59uNJvaZ1am0sNzJFfJmb2ED4XsDOBZ9wQnlNXg/vrQwWOhePJe24tu7og==", 2, "1803261039" },
                    { 39, "Георги", "Бютюнев", "AQAAAAEAACcQAAAAEG7YUrK+BQhA7jaAeSy349rtLCiAYflCBTGc6KWmO2MG/mGilvd0pnNRG2K22/9pqw==", 2, "1803261038" },
                    { 38, "Тони", "Момчилова", "AQAAAAEAACcQAAAAEJUHqsZT9C0V955VexB69DOp3lNsbqZ/X6AgRXa07uOUPPa/zs3RrwDh/8PnFj5EUw==", 2, "1803261037" },
                    { 37, "Димитрия", "Христева", "AQAAAAEAACcQAAAAEOM491pdVkwkSmPuk2XpE3vcZOk01w0RenY2X9X+P/BA6CoVMwb7GQfi5xpEjw+mjw==", 2, "1803261036" },
                    { 36, "Теодор", "Боянов", "AQAAAAEAACcQAAAAEC3Ki6nSx2ARVWorV8Co+/qEEwIHd75VKTDMwXnklg+A8cd+dhawKfs/VC73HofBQQ==", 2, "1803261035" },
                    { 35, "Бедреттин", "Бекир", "AQAAAAEAACcQAAAAEDyPK4rh3XLeM+vbv1A23gp+jtZ17A0ozonOStFCJfqQNZPTdtNCTNLWIc26dLGuRg==", 2, "1803261034" },
                    { 34, "Сабри", "Юмер", "AQAAAAEAACcQAAAAEA85/RfM0XxZVe8aqbLDgvoU3xmBSZCtU5RGewFvl7//Z1hkKZhNvcrbEiKwR5Ah5w==", 2, "1803261033" },
                    { 33, "Даниел", "Леви", "AQAAAAEAACcQAAAAEHcRK9NC9TAuNMwoX4bE9Ih4rdFewvxS6P2QLhywvUyOLS9vHNDTWSoqNjGGyNZhPw==", 2, "1803261032" },
                    { 32, "Петър", "Маламов", "AQAAAAEAACcQAAAAEMC6keVbIDpaDEtv57Eo+1HN8UWC++zx++L+8AaSUgMegmW6I71zSKLIjKyPSX3dXg==", 2, "1803261031" },
                    { 31, "Петър", "Узунов", "AQAAAAEAACcQAAAAEBcQZSr5lquHjbHXBIBSVTuxHoUg73Nitqlesv4PzgOldeqCEW2UYbHkdFs+daK+Kw==", 2, "1803261030" },
                    { 30, "Надежда", "Георгиева", "AQAAAAEAACcQAAAAEOvjldcwVYYjlXD5cMk2/nGta8Gik+Oq6Jq8PvCRAl5YFpikfNwsrS3tgyUmNRlPvQ==", 2, "1803261029" },
                    { 29, "Росен", "Рунтев", "AQAAAAEAACcQAAAAEHDjrEidlBVRO+397d67ykazHf4ZFvGE8PeSmUCuvShtwC/8f+R3RHMXTrfasC4xmg==", 2, "1803261028" },
                    { 27, "Никола", "Сидеров", "AQAAAAEAACcQAAAAEI0clmZCY81oWnvhsmUhmXGm0fzPv05S+IAq3bd8OIokn+66EWSN6MWOUi2Zl4PoqA==", 2, "1803261026" },
                    { 107, "Николай", "Вълчанов", "AQAAAAEAACcQAAAAEPFEtx07dZ+PnuQbpmUrZvOW7Vy7xR2NCncSaOLHGwZ8cckOOaaIjrLxMMK1OJXEaA==", 1, "nikiv" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 107);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Logins",
                type: "varchar(60) CHARACTER SET utf8mb4",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }
    }
}
