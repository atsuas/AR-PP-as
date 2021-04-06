using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 10章で説明する Regexクラスを利用し、ゼロサプレスすれば、目的の結果が得られる。
        // 年も2桁固定で、ゼロサプレスできる。
        private static void DisplayDatePattern3_2(DateTime dateTime)
        {
            // 次のようにも書いた場合、結果が異なる                
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            // dddd で 日曜日 などの文字列を得ることができる
            var dateStr = dateTime.ToString("ggyy年MM月dd日(dddd)", culture);
            var str = Regex.Replace(dateStr, @"0(\d)", " $1");
            Console.WriteLine(str);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
