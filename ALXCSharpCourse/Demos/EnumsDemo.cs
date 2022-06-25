using ALXCSharpCourse.Enums;
using ALXCSharpCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demos
{
    public class EnumsDemo
    {
        public static void Run()
        {
            EmailMessage message = new EmailMessage
                (
                    "jankowal@wp.pl",
                    "mmalina@gmail.com",
                    "sprzedam opla",
                     MessageStatus.DRAFT
                );
            message.ChangeStatus(MessageStatus.SENT);
        }
    }
}
