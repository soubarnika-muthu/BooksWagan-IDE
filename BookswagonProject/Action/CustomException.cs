/*Project =Selenium Automation Testing -BooksWagan 
 * created by = Soubarnika Muthu
 * date = 05/10/2021
 */
using System;

namespace BookswagonProject.Action
{
    public class CustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            NULL_EXCEPTION, CLASS_NOT_FOUND, METHOD_NOT_FOUND, WebDriverException, NoSuchElementException, NoSuchWindowException, InvalidSelectorException, NoSuchSessionException, FileNotFoundException,
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
