using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_TradeComissions
    {
    class Program
        {
        static void Main(string[] args)
            {
            var town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            var percent = 0.0;
            var commision = -1.0;

            if (sales >= 0 && sales <= 500)
                {
                if (town == "sofia")
                    {
                    percent = 0.05;
                    }
                else
                    {
                    if (town == "varna")
                        {
                        percent = 0.045;
                        }
                    else
                        {
                        if (town == "plovdiv")
                            {
                            percent = 0.055;
                            }
                        }
                    }
                } // [0..500]
            else
                {
                if (sales > 500 && sales <= 1000)
                    {
                    if (town == "sofia")
                        {
                        percent = 0.07;
                        }
                    else
                        {
                        if (town == "varna")
                            {
                            percent = 0.075;
                            }
                        else
                            {
                            if (town == "plovdiv")
                                {
                                percent = 0.08;
                                }
                            }
                        }
                    } // (500..1000]
                else
                    {
                    if (sales > 1000 && sales <= 10000)
                        {
                        if (town == "sofia")
                            {
                            percent = 0.08;
                            }
                        else
                            {
                            if (town == "varna")
                                {
                                percent = 0.1;
                                }
                            else
                                {
                                if (town == "plovdiv")
                                    {
                                    percent = 0.12;
                                    }
                                }
                            }
                        } // (1000..10 000]
                    else
                        {
                        if (sales > 10000)
                            {
                            if (town == "sofia")
                                {
                                percent = 0.12;
                                }
                            else
                                {
                                if (town == "varna")
                                    {
                                    percent = 0.13;
                                    }
                                else
                                    {
                                    if (town == "plovdiv")
                                        {
                                        percent = 0.145;
                                        }
                                    }
                                }
                            } // (10 000 ... )
                        }
                    }
                }

            if ((town != "sofia" && town != "varna" && town != "plovdiv") || sales < 0)
                {
                Console.WriteLine("error");
                }
            else
                {
                commision = sales * percent;
                Console.WriteLine("{0:f2}", commision);
                }

            }
        }
    }
