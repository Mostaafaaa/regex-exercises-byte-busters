using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace regex_exercises
{
    public class RegecFunctions
    {


        // 1. Match all phone numbers in a local format like 0790xxxxxxx
        // Test String: My number is 07901234567.
        // Goal: Match numbers starting with 0790 and 7 digits.
        // Arabic: استخراج أرقام الهواتف المحلية
        // Kurdish: ژمارە تەلەفۆنە ناوخۆییەکان بدۆزەرەوە
        // 
        //sol, i will create regex to solve this problem
        public static bool MatchAllPhoneNumberInLocalFormat(string phoneNumber)
        {
            string pattern = @"^0790\d{7}";
            try
            {
                // safety check
                if (string.IsNullOrWhiteSpace(phoneNumber))
                {
                    Console.WriteLine("Input is null or empty.");
                    return false;
                }
                bool IsphoneNumberMatchPattren = (Regex.IsMatch(phoneNumber, pattern));
                if (IsphoneNumberMatchPattren)
                {
                    Console.WriteLine("Valid phone number.");
                }
                else
                {
                    Console.WriteLine("Invalid phone number format.");
                }
                return IsphoneNumberMatchPattren;
            }
            catch (Exception eror)
            {
                Console.WriteLine("Error occurred: " + eror.Message);
                return false;
            }
        }

        // 2. Match all email addresses
        // Test String: Contact me at ali@example.com or support @halal.io
        // Goal: Extract emails
        // Arabic: استخراج البريد الإلكتروني
        // Kurdish: ئیمەیلەکان بدۆزەرەوە
        // 

        public static bool MatchAllEmailAddress(string EmailAddress)
        {
            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

            try
            {
                // safety check
                if (string.IsNullOrWhiteSpace(EmailAddress))
                {
                    Console.WriteLine("Email Address is null or empty.");
                    return false;
                }
                bool IsMatchAllEmailAddress = (Regex.IsMatch(EmailAddress, pattern));
                if (IsMatchAllEmailAddress)
                {
                    Console.WriteLine("Valid Email Address.");
                }
                else
                {
                    Console.WriteLine("Invalid Email Address format.");
                }
                return IsMatchAllEmailAddress;
            }
            catch (Exception eror)
            {
                Console.WriteLine("Error occurred: " + eror.Message);
                return false;
            }
        }
        // 3. Match any word that starts with a capital letter
        // Test String: Ali went to Basra and met Noor.
        // Goal: Find proper nouns
        // Arabic: إيجاد أسماء العلم
        // Kurdish: ناونیشانی خاس بدۆزەوە
        // 
        public static bool MatchAnyWordStartWithCapitalLetter(string InputString)
        {
            string pattern = @"\b[A-Z][a-z]+\b";

            try
            {
                // safety check
                if (string.IsNullOrWhiteSpace(InputString))
                {
                    Console.WriteLine("Input is null or empty.");
                    return false;
                }
                bool IsProperNouns = Regex.IsMatch(InputString, pattern);
                if (!IsProperNouns)
                {
                    Console.WriteLine("No word starts with capital letter");
                }
                else
                {
                    Console.WriteLine("There is one or more word with Capital letter");
                }
                return IsProperNouns;
            }
            catch (Exception eror)
            {
                Console.WriteLine("Error occurred: " + eror.Message);
                return false;
            }
        }
        // 4. Match all numbers (integers only)
        // Test String: I have 2 cats and 10 chickens.
        // Arabic: إيجاد الأرقام
        // Kurdish: ژمارەیەکان بدۆزەوە
        // 
        public static bool MatchAllNumbers(string InputString)
        {
            string pattern = @"\d+";
            try
            {
                // safety check
                if (string.IsNullOrWhiteSpace(InputString))
                {
                    Console.WriteLine("Input is null or empty.");
                    return false;
                }

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfAppearingNumbers = matches.Count;

                if (NumberOfAppearingNumbers == 0)
                {
                    Console.WriteLine("No numbers found in the input");
                    return false;
                }
                else
                {
                    Console.WriteLine($"There are {NumberOfAppearingNumbers} numbers in the input:");
                    foreach (Match match in matches)
                    {
                        Console.WriteLine($"- {match.Value}");
                    }
                    return true;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occurred: " + error.Message);
                return false;
            }
        }
    

        // 5. Match all hashtags
        // Test String: #blessed #codingLife
        // Arabic: استخراج الهاشتاغ
        // Kurdish: هاشتاکەکان بدۆزەوە
        // 
          public static bool MatchAllHashtags(string InputString)
        {
            string pattern = @"#\w+";
            try
            {
                // safety check
                if (string.IsNullOrWhiteSpace(InputString))
                {
                    Console.WriteLine("Input is null or empty.");
                    return false;
                }

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfAppearingHashtags = matches.Count;

                if (NumberOfAppearingHashtags == 0)
                {
                    Console.WriteLine("No Hashtags found in the input");
                    return false;
                }
                else
                {
                    Console.WriteLine($"There are {NumberOfAppearingHashtags} Hashtags in the input:");
                    foreach (Match match in matches)
                    {
                        Console.WriteLine($"- {match.Value}");
                    }
                    return true;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occurred: " + error.Message);
                return false;
            }
        }
    }
        // 6. Match all words ending in "ing"
        // Test String: I am coding, running, and learning.
        // Arabic: الكلمات التي تنتهي بـ ing
        // Kurdish: وشەکان کە بە ing کۆتایی دەن
        // 

        // 7. Find all currency amounts ($100, $29.99)
        // Test String: I spent $100 on food and $29.99 on drinks.
        // Arabic: المبالغ المالية
        // Kurdish: بڕی پارە بدۆزەوە
        // 
        // 8. Match time like 12:30 or 04:55
        // Test String: The meeting is at 12:30.
        // Arabic: مطابقة الوقت
        // Kurdish: کاتی بە شێوەی hh:mm بدۆزەوە
        // 
        // 9. Match dates like 2025-07-10
        // Test String: Today is 2025-07-10
        // Arabic: استخراج التاريخ
        // Kurdish: ڕێکەوتەکان بدۆزەوە
        // 
        // 10. Match a single Arabic word
        // Test String: هذه كلمة عربية.
        // Arabic: استخراج كلمة عربية واحدة
        // Kurdish: وشەی عەرەبی بدۆزەوە
        // 
        // 
        // 11. Match any word that starts with “un”
        // Test String: unknown, unhappy, unlocked
        // Arabic: الكلمات التي تبدأ بـ un
        // Kurdish: وشەکان کە بە un دەست پێدەکەن
        // 
        // 12. Match all Kurdish words (basic check)
        // Test String: ئەمە وشەیەکی کوردییە
        // Arabic: مطابقة الكلمات الكردية
        // Kurdish: وشەی کوردی بدۆزەوە
        // 
        // 13. Validate a username (alphanumeric, 4–12 chars)
        // Test String: Ali123
        // Arabic: التحقق من صحة اسم المستخدم
        // Kurdish: ناوی بەکارهێنەر پشتڕاست بکەوە
        // 
        // 14. Match any HTML tag
        // Test String: <div>Hello</div>
        // Arabic: مطابقة الوسوم
        // Kurdish: تاگە HTML ـکان بدۆزەوە
        // 
        // 15. Match any sentence ending with a question mark
        // Test String: How are you? Is this okay?
        // Arabic: الأسئلة
        // Kurdish: پرسیارەکان بدۆزەوە
        // 
        // 16. Find duplicate words
        // Test String: this is is a test
        // Arabic: تكرار الكلمات
        // Kurdish: وشەی دووجارکراو بدۆزەوە
        // 
        // 17. Extract file extensions(.jpg, .pdf)
        // Test String: photo.jpg, resume.pdf
        // Arabic: استخراج الامتدادات
        // Kurdish: پاشگرەکانی فایل بدۆزەوە
        // 
        // 18. Match Iraqi license plates(e.g., ب 12345)
        // Test String: ب 12345
        // Arabic: مطابقة رقم السيارة
        // Kurdish: ژمارەی ئۆتۆمبێلە عێراقییەکان بدۆزەوە
        // 
        // 19. Find words with diacritics(Arabic harakat)
        // Test String: تَجْرِبَةٌ
        // Arabic: علامات التشكيل
        // Kurdish: نیشانەکانی تەشکیل بدۆزەوە
        // 
        // 20. Extract URLs
        // Test String: Visit https://halal.io today!
        // Arabic: روابط الإنترنت
        // Kurdish: بەستەرەکان بدۆزەوە
        // 
        // 
        // 21. Validate strong password
        // Arabic: التحقق من قوة كلمة المرور
        // Kurdish: پشتڕاستکردنی نهێنوشەی بەهێز
        // 
        // 22. Match emojis(basic)
        // Test String: 😊 ❤️ 🔥
        // Arabic: استخراج الرموز التعبيرية
        // Kurdish: ئیمۆجیەکان بدۆزەوە
        // 
        // 23. Match valid IPv4 addresses
        // Test String: 192.168.0.1
        // Arabic: عنوان IP
        // Kurdish: ناونیشانی IP بدۆزەوە
        // 
        // 24. Find Quran surah references(e.g., 2:255)
        // Test String: See 2:255 for Ayat al-Kursi
        // Arabic: آيات القرآن
        // Kurdish: ناونیشانی سۆرەکان بدۆزەوە
        // 
        // 25. Match numbers in Arabic numerals(١٢٣٤٥)
        // Test String: سعره ١٢٣ د.ع
        // Arabic: الأرقام العربية
        // Kurdish: ژمارەی عەرەبییەکان بدۆزەوە
        // 
        // 26. Match repeated character sequences
        // Test String: loooool, yessss
        // Arabic: الحروف المتكررة
        // Kurdish: پێکراوەی وشەکان بدۆزەوە
        // 
        // 27. Extract Quranic Basmalah only
        // Arabic: البسملة
        // Kurdish: دەسپێکی سۆرەکان بدۆزەوە
        // 
        // 28. Match IBAN numbers
        // Test String: IQ44NBIQ123456789012345
        // Arabic: رقم الحساب الدولي
        // Kurdish: ژمارەی IBAN بدۆزەوە
        // 
        // 29. Extract YouTube video ID
        // Test String: https://www.youtube.com/watch?v=abc123xyz
        // Arabic: معرف فيديو يوتيوب
        // Kurdish: ناسنامەی ڤیدیۆی YouTube بدۆزەوە
        // 
        // 30. Match JSON key-value pairs
        // Test String: { "name": "Ali", "age": "30" }
        //     Arabic: استخراج البيانات من JSON
        // Kurdish: داتاکان لە JSON بدۆزەوە
        // 
        // 

    }
    