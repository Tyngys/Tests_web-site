using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CP.Web.Models
{
    public class TestOneModel
    {
        public List<TestOne> ArrayAllTests { get; set; } = new List<TestOne>();

        public TestOneModel()
        {
            this.ArrayAllTests.Add(new TestOne("1.   Мне легче что - либо сделать самому, чем объяснить другому."));
            this.ArrayAllTests.Add(new TestOne("2.   Мне интересно составлять компьютерные программы."));
            this.ArrayAllTests.Add(new TestOne("3.   Я люблю читать книги"));
            this.ArrayAllTests.Add(new TestOne("4.   Мне нравится живопись, скульптура, архитектура."));
            this.ArrayAllTests.Add(new TestOne("5.   Даже в отлаженном деле я стараюсь что-то улучшить."));
            this.ArrayAllTests.Add(new TestOne("6.   Я лучше понимаю, если мне объясняют на предметах или рисунках."));
            this.ArrayAllTests.Add(new TestOne("7.   Я люблю играть в шахматы."));
            this.ArrayAllTests.Add(new TestOne("8.   Я легко излагаю свои мысли как в устной, так и в письменной форме."));
            this.ArrayAllTests.Add(new TestOne("9.   Когда я читаю книгу, я четко вижу ее героев и описываемые события."));
            this.ArrayAllTests.Add(new TestOne("10.  Я предпочитаю самостоятельно планировать свою работу."));
            this.ArrayAllTests.Add(new TestOne("11.  Мне нравится  все делать своими руками."));
            this.ArrayAllTests.Add(new TestOne("12.  В детстве я создавал (а) свой шифр для переписки с друзьями."));
            this.ArrayAllTests.Add(new TestOne("13.  Я придаю большое значение  сказанному слову."));
            this.ArrayAllTests.Add(new TestOne("14.  Знакомые мелодии вызывают у меня в голове определенные картины."));
            this.ArrayAllTests.Add(new TestOne("15.  Разнообразные увлечения делают жизнь человека богаче и ярче."));
            this.ArrayAllTests.Add(new TestOne("16.  При решении задачи мне легче идти методом проб и ошибок."));
            this.ArrayAllTests.Add(new TestOne("17.  Мне интересно разбираться в природе физических явлений."));
            this.ArrayAllTests.Add(new TestOne("18.  Мне интересна  работа ведущего теле-радиопрограмм, журналиста."));
            this.ArrayAllTests.Add(new TestOne("19.  Мне легко представить предмет или животное, которых нет в природе."));
            this.ArrayAllTests.Add(new TestOne("20.  Мне больше нравится процесс деятельности, чем  сам результат."));
            this.ArrayAllTests.Add(new TestOne("21.  Мне нравилось в детстве собирать конструктор из деталей, лего."));
            this.ArrayAllTests.Add(new TestOne("22.  Я предпочитаю точные науки (математику, физику)."));
            this.ArrayAllTests.Add(new TestOne("23.  Меня восхищает точность и глубина некоторых стихов."));
            this.ArrayAllTests.Add(new TestOne("24.  Знакомый запах   вызывает в моей памяти прошлые события."));
            this.ArrayAllTests.Add(new TestOne("25.  Я не хотел (а) бы подчинять свою жизнь определенной системе."));
            this.ArrayAllTests.Add(new TestOne("26.  Когда я слышу музыку, мне хочется танцевать."));
            this.ArrayAllTests.Add(new TestOne("27.  Я понимаю красоту математических формул."));
            this.ArrayAllTests.Add(new TestOne("28.  Мне легко говорить перед любой аудиторией."));
            this.ArrayAllTests.Add(new TestOne("29.  Я люблю посещать выставки, спектакли, концерты."));
            this.ArrayAllTests.Add(new TestOne("30.  Я сомневаюсь даже в том, что для других очевидно."));
            this.ArrayAllTests.Add(new TestOne("31.  Я люблю заниматься рукоделием, что-то мастерить."));
            this.ArrayAllTests.Add(new TestOne("32.  Мне интересно было бы расшифровать древние тексты."));
            this.ArrayAllTests.Add(new TestOne("33.  Я легко усваиваю грамматические конструкции языка."));
            this.ArrayAllTests.Add(new TestOne("34.  Красота для меня важнее, чем польза."));
            this.ArrayAllTests.Add(new TestOne("35.  Не люблю ходить одним и тем же путем."));
            this.ArrayAllTests.Add(new TestOne("36.  Истинно только то, что можно потрогать руками."));
            this.ArrayAllTests.Add(new TestOne("37.  Я легко запоминаю формулы,  символы, условные обозначения."));
            this.ArrayAllTests.Add(new TestOne("38.  Друзья любят слушать, когда я им что-то рассказываю."));
            this.ArrayAllTests.Add(new TestOne("39.  Я легко могу представить в образах содержание рассказа или  фильма."));
            this.ArrayAllTests.Add(new TestOne("40.  Я не могу  успокоиться, пока не доведу свою работу до совершенства. "));
        }

        public int[] GetMarksFromAnswer(TestOneModel oneModel)
        {
            int[] marks = new int[5];
            for (int i = 0; i < oneModel.ArrayAllTests.Count(); i++)
            {
                if (oneModel.ArrayAllTests[i].Answer.Equals("Yes") && (i == 0 || i%5 == 0))
                {
                    marks[0]++;
                }
                else if(oneModel.ArrayAllTests[i].Answer.Equals("Yes") && (i == 1 || i == 6 || i==11 || i==16 || i==21 || i == 26 || i == 31 || i == 36))
                {
                    marks[1]++;
                }
                else if(oneModel.ArrayAllTests[i].Answer.Equals("Yes") && (i == 2 || i == 7 || i == 12 || i == 17 || i == 22 || i == 27 || i == 32 || i == 37))
                {
                    marks[2]++;
                }
                else if (oneModel.ArrayAllTests[i].Answer.Equals("Yes") && (i == 3 || i == 8 || i == 13 || i == 18 || i == 23 || i == 28 || i == 33 || i == 38))
                {
                    marks[3]++;
                }
                else if (oneModel.ArrayAllTests[i].Answer.Equals("Yes") && (i == 4 || i == 9 || i == 14 || i == 19 || i == 24 || i == 29 || i == 34 || i == 39))
                {
                    marks[4]++;
                }
            }
            return marks;
        }
    }
}