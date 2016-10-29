using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CP.Data.Models;

namespace CP.Web.Models
{
    public class TestSecondModel
    {
        public List<TestSecond> ListSecondTest { get; set; } = new List<TestSecond>();

        public TestSecondModel()
        {
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое означало бы то же, что и слова, стоящие вне скобок: ТКАНЬ (...) СОСТОЯНИЕ ВЕЩЕСТВА", "ГАЗ"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое служило бы окончанием первого слова и началом второго: ГО(...)КОТ", "БОЙ"));
            this.ListSecondTest.Add(new TestSecond("Решите анаграммы и исключите лишнее слово: КОХЙЕК   СНИНЕТ   ОЖИВТ   ЛУФОБТ", "ЖИВОТ"));
            this.ListSecondTest.Add(new TestSecond("Найдите общее окончание для всех перечисленных слов:  ДР...,М...,ТР...,Ц...,Щ...,ЯГ...", "ЕЛЬ"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое означало бы то же, что и слова, стоящие вне скобок: ЖИВОТНОЕ (...) МОНАХ", "ЛАМА"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое служило бы окончанием первого слова и началом второго: СНА(...)ОВОЙ", "РЯД"));
            this.ListSecondTest.Add(new TestSecond("Исключите лишнее слово: ОЗУКРА;  НИШПАЯЛ;  НИБОВОС; НИШКУП", "ПУШКИН"));
            this.ListSecondTest.Add(new TestSecond("Найдите общее начало для трех следующих слов: БУРКА, ГОРЕЦ, КНИЖНИК", "ЧЕРНО"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое означало бы то же, что и слова, стоящие вне скобок: РОДНИК(....)ОТМЫЧКА", "КЛЮЧ"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое служило бы окончанием первого слова и началом второго ПЕ(...)ОЛ", "СО"));
            this.ListSecondTest.Add(new TestSecond("Исключите лишнее слово: АЧТПО; АИДРО; ФАГРЕЛТЕ; КТЕВИНЦ", "ЦВЕТНИК"));
            this.ListSecondTest.Add(new TestSecond("Найдите общее начало для трех следующих слов: ВОЗ, НОС, РАЗДЕЛ", "ВОДО"));
            this.ListSecondTest.Add(new TestSecond("Найдите слово, которое служило бы окончанием первого слова и началом второго: ТА(...)AT", "ПИР"));
            this.ListSecondTest.Add(new TestSecond("Найдите слово, которое означало бы то же, что и слова, стоящие вне скобок: БИТВА(...)РУГАНЬ", "БРАНЬ"));
            this.ListSecondTest.Add(new TestSecond("Исключите лишнее слово: АПНИСЕЛЬ; ЯШВИН; ТАСУПАК; АКАЧКБО; ШУРГА", "ВИШНЯ"));
            this.ListSecondTest.Add(new TestSecond("Исключите лишнее слово: ЮКИЛТ; ЛЮТАНЬП; АЛИФАК; ОЗАР; ЛСТУ", "СТУЛ"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое служило бы окончанием первого слова и началом второго: БАЛ(...)ЕДА", "БЕС"));
            this.ListSecondTest.Add(new TestSecond("Найдите общее окончание для следующих слов: В...; Г...; Д..., К...,  М...,  П...,  СТ..., Т..., УГ...,  УК...,  Ф...", "ОЛ"));
            this.ListSecondTest.Add(new TestSecond("Найдите общее окончание для всех перечисленных слов: Д...; К..., С..., Р...", "ОМ"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое означало бы то же, что и слова, стоящие вне скобок: РЫБА (....) НАКЛОННАЯ ПОВЕРХНОСТЬ", "СКАТ"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое служило бы окончанием первого слова и началом второго: ДИК(.....)ЕЦ", "ОБРАЗ"));
            this.ListSecondTest.Add(new TestSecond("Исключите лишнее слово: РАКОЧВА; ЛЬБГДОУ; EXPO; ЛУПЕДЬ", "ОРЕХ"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое означало бы то же, что и слова стоящие вне скобок: НАСЫПЬ (...) ВРАЩАЮЩИЙСЯ СТЕРЖЕНЬ", "ВАЛ"));
            this.ListSecondTest.Add(new TestSecond("Найдите общее окончание для всех последующих слов: В..., Ж..., Л..., М...,Т..., Ч..., Ш...", "ЕСТЬ"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое служило бы окончанием первого слова и началом второго: СА(...)ОН", "РАЙ"));
            this.ListSecondTest.Add(new TestSecond("Исключите лишнее слово: ЗМАТЕ; РАЖПИ; АГОВЛ; ИНЕРГ", "ПАРИЖ"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое означало бы то же, что и слова, стоящие вне скобок: ЧАСТЬ ОДЕЖДЫ(...)ГРУЗОПОДЪЕМНЫЙ МЕХАНИЗМ", "ВОРОТ"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое служило бы окончанием первого слова и началом второго: У(....)Ь", "КЛАД"));
            this.ListSecondTest.Add(new TestSecond("Исключите лишнее слово: СЛОО; ОКОТИ; ООТРОНТ; РЕБЛАГД", "БЕЛГРАД"));
            this.ListSecondTest.Add(new TestSecond("Найдите общее окончание для всех последующих слов Б...,Л...,М...,П...,С...,СТ...,СП...,Ч...Ш...", "АЙКА"));
            this.ListSecondTest.Add(new TestSecond("Найдите общее окончание для всех последующих слов В...,ГЛ...,Д...,ДЛ...,М...,ОС...,Т...", "ИНА"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое означало бы то же, что и слова, стоящие вне скобок: ЖИВОТНОЕ(...)НЕЖНОСТЬ", "ЛАСКА"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое служило бы окончанием первого слова и началом второго: КОВЕР (...) ЛЕТА", "КОТ"));
            this.ListSecondTest.Add(new TestSecond("Исключите лишнее слово: ЛЕОР; БЕОРОЙВ; КОВАОРЖОН; ФЕЛИНДЬ", "ДЕЛЬфИН"));
            this.ListSecondTest.Add(new TestSecond("Найдите общее окончание для всех последующих слов: Б..., ГР..., Д..., ЕН..., К..., Л..., М..., П..., ПЛ..., Р..., СК...", "ОТ"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое служило бы окончанием первого слова и началом второго: КАБ(...)ОШКО", "ЛУК"));
            this.ListSecondTest.Add(new TestSecond("Исключите лишнее слово: НЙЕНЙЭШТ, КИНСЕКД, ВЕХЧО, ЗАКАЛЬБ, СЙТООТЛ", "ЭЙНШТЕЙН"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое означало бы то же, что и слова, стоящие вне скобок: САМОВОЛЬНЫЙ УХОД(...)МОЛОДАЯ ВЕТКА", "ПОБЕГ"));
            this.ListSecondTest.Add(new TestSecond("Найдите общее окончание для всех последующих слов: В..., Ж..., Й...,М...,П...,Ц...", "ЕНА"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое означало бы то же, что и слова, стоящие вне скобок: ПРЕДЛОГ(...)РЕМЕНЬ УЗДЫ", "ПОВОД"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое служило бы окончанием первого слова и началом второго: С(...)ОКНО", "ТОЛ"));
            this.ListSecondTest.Add(new TestSecond("Исключите лишнее слово: ЛИОРЗТЕВЕ; ОИКСМТ; РКМОА; МИТТЕР", "ТЕЛЕВИЗОР"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое означало бы то же, что и слова, стоящие вне скобок: КОСТОЧКА ПАЛЬЦА(...)ПАУКООБРАЗНОЕ", "ФАЛАНГА"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое служило бы окончанием первого слова и началом второго: ГА(...)РЕЛЬ", "МАК"));
            this.ListSecondTest.Add(new TestSecond("Найдите общее окончание для всех последующих слов  Б...,Д...,К...,М...,Н...,П...,Т...", "ОЧКА"));
            this.ListSecondTest.Add(new TestSecond("Исключите лишнее слово: ЗОАК; РЕОББ; СФОМАРЕ; ШАДОЛЬ", "СЕМАФОР"));
            this.ListSecondTest.Add(new TestSecond("Найдите общее окончание для всех последующих слов: Д….,Л….,С…..,Т…..,ОС….., ЯС……", "ЕНЬ"));
            this.ListSecondTest.Add(new TestSecond("Вставьте слово, которое служило бы окончанием первого слова и началом второго: Г(...)ОЖА", "РОГ"));
            this.ListSecondTest.Add(new TestSecond("Найдите общее окончание для всех последующих слов: Б...,Г...,М...,Р...,С...,Т...,К...,Р...", "ОЛЬ"));
            this.ListSecondTest.Add(new TestSecond("Исключите лишнее слово: ТРБА, КПИРАКС, ТРСАЕС, АТМЬ, НКВЧУА", "СКРИПКА"));
        }

        public int GetMark(TestSecondModel model)
        {
            int summ = 0;
            for (int i = 0; i < model.ListSecondTest.Count(); i++)
            {
                if(Equals(model.ListSecondTest[i].Answer,model.ListSecondTest[i].RightAnswer))
                {
                    summ++;
                }
            }
            return summ;
        }
    }
}