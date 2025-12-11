using System;

namespace Financial_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mainOption = 0, plan = 0, choice = 0;
            double income = 0.0, rent = 0.0, necessities = 0.0;
            double totalNeeds = 0.0, needsPercent = 0.0, wantsPercent = 0.0, savingsPercent = 0.0;
            double needsTotal = 0.0, wantsTotal = 0.0, savingsTotal = 0.0;

            // MAIN MENU LOOP
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hello to our Financial Helper!");
                Console.WriteLine("1. Financial Tips");
                Console.WriteLine("2. Improve your credit score");
                Console.WriteLine("3. Advice for future home");
                Console.WriteLine("4. Budget Calculator");
                Console.WriteLine("5. Exit Program");
                Console.Write("Which option would you like: (1-5): ");

                mainOption = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                // =======================
                // Option 1: Financial Tips
                // =======================
                if (mainOption == 1)
                {
                    Console.Write("Welcome to Financial Tips!\n");
                    Console.Write("What Day are you on: (1-31)\n");
                    int day = Convert.ToInt32(Console.ReadLine());

                    switch (day)
                    {
                        case 1:
                            Console.WriteLine("Everyone dies someday, so make a will so the state doesn't decide what happens to your belongings or children.");
                            break;
                        case 2:
                            Console.WriteLine("Emergencies happen. Always keep 3-6 months of living expenses saved.");
                            break;
                        case 3:
                            Console.WriteLine("Even after school, keep learning about money and finances.");
                            break;
                        case 4:
                            Console.WriteLine("Be careful who you take money advice from. Good intentions don't replace real experience.");
                            break;
                        case 5:
                            Console.WriteLine("It's not how much money you make, but how much you keep.");
                            break;
                        case 6:
                            Console.WriteLine("Money disappears quickly if you don't understand how to manage it.");
                            break;
                        case 7:
                            Console.WriteLine("Learn the difference between assets and liabilities.");
                            break;
                        case 8:
                            Console.WriteLine("Education and career success are great, but financial literacy is just as important");
                            break;
                        case 9:
                            Console.WriteLine("Assets aren't just investments, knowledgeable friends like attorneys, accountants, and bankers can be assets too.");
                            break;
                        case 10:
                            Console.WriteLine("If you're not earning a high income or building a business, plan ahead because you might rely more on retirement saving.");
                            break;
                        case 11:
                            Console.WriteLine("Wealth is measured by how long you can live without working. Know your number and work toward it.");
                            break;
                        case 12:
                            Console.WriteLine("Waiting for the perfect time to invest means you may never start.");
                            break;
                        case 13:
                            Console.WriteLine("Your mind is your best asset, strengthen it by learning about finances.");
                            break;
                        case 14:
                            Console.WriteLine("Don't only save, learn where and how to invest your money.");
                            break;
                        case 15:
                            Console.WriteLine("Investing with knowledge is smart; investing without understanding is basically gambling.");
                            break;
                        case 16:
                            Console.WriteLine("Make sure your hard work is leading to financial progress, not just survival.");
                            break;
                        case 17:
                            Console.WriteLine("Many smart people struggle financially because of what they don't know.");
                            break;
                        case 18:
                            Console.WriteLine("Buying companies you don't understand isn't investing but guessing.");
                            break;
                        case 19:
                            Console.WriteLine("Fast money schemes are risky, just because they work once doesn't make them safe.");
                            break;
                        case 20:
                            Console.WriteLine("Invest in things you actually understand, not hype, news, or daily price movements.");
                            break;
                        case 21:
                            Console.WriteLine("Dollar cost averaging is a reliable way to build wealth slowly over time.");
                            break;
                        case 22:
                            Console.WriteLine("Day traders pay higher taxes. Holding strong companies or ETFs for over a year gets you taxed less.");
                            break;
                        case 23:
                            Console.WriteLine("For beginners, ETFs are safer than picking individual stocks.");
                            break;
                        case 24:
                            Console.WriteLine("Falling stock prices can be good for long term investors, use them as buying opportunities.");
                            break;
                        case 25:
                            Console.WriteLine("Don't rely only on past performance; look at future growth potential.");
                            break;
                        case 26:
                            Console.WriteLine("Good financial times can hide bad spending habits; be aware of them.");
                            break;
                        case 27:
                            Console.WriteLine("Track your money now. Don't wait until you're older or trouble ta start managing finances.");
                            break;
                        case 28:
                            Console.WriteLine("A cheap, reliable used car is often smarter than buying a brand new one.");
                            break;
                        case 29:
                            Console.WriteLine("A 0% interest new car can still be a bad deal because the car losses value fast.");
                            break;
                        case 30:
                            Console.WriteLine("Mobile homes only increases in value if the land does. Know what you're actually buying.");
                            break;
                        case 31:
                            Console.WriteLine("Changing money habits takes personal responsinility; no one can do it for you.");
                            break;
                        default:
                            Console.WriteLine("You have done all financial tips for this month!");
                            break;
                    }

                    Pause();
                }

                // ======================
                // Option 2: Credit Score
                // ======================
                else if (mainOption == 2)
                {
                    bool stayInCreditMenu = true;

                    while (stayInCreditMenu)
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome to ways to increase your credit score!");
                        Console.WriteLine("Choose a tip to view (1-10):");
                        Console.WriteLine("1) Keep your credit use low");
                        Console.WriteLine("2) Always pay your credit cards on time");
                        Console.WriteLine("3) Don't close old credit cards");
                        Console.WriteLine("4) Ask for a credit limit increase");
                        Console.WriteLine("5) Have different types of credit");
                        Console.WriteLine("6) Only open accounts when needed");
                        Console.WriteLine("7) Become (or use) an authorized user");
                        Console.WriteLine("8) Help your child build credit early");
                        Console.WriteLine("9) Keep balances under 10% of your limit");
                        Console.WriteLine("10) Small habits add up over time");
                        Console.WriteLine("0) Return to Main Menu");
                        Console.Write("\nChoose (0-10): ");

                        int creditChoice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        switch (creditChoice)
                        {
                            case 1:
                                Console.WriteLine("1. Keep your credit use low");
                                Console.WriteLine("Tip: Try to use only a small amount of your credit.");
                                Console.WriteLine("Example: If your card limit is $10,000, try to owe less than $1,000.");
                                Pause();
                                break;

                            case 2:
                                Console.WriteLine("2. Always pay your credit cards on time.");
                                Console.WriteLine("Tip: Late payments hurt your score a lot, so pay on time.");
                                Console.WriteLine("Example: Turn on auto-pay so you never forget a payment.");
                                Pause();
                                break;

                            case 3:
                                Console.WriteLine("3. Don't close old credit cards.");
                                Console.WriteLine("Tip: Old accounts help your score because they show long credit history.");
                                Pause();
                                break;

                            case 4:
                                Console.WriteLine("4. Ask for a credit limit increase.");
                                Console.WriteLine("Tip: A higher limit lowers your utilization percentage.");
                                Console.WriteLine("Example: If your limit goes from $5,000 to $7,000, using $500 looks better.");
                                Pause();
                                break;

                            case 5:
                                Console.WriteLine("5. Have different types of credit.");
                                Console.WriteLine("Tip: Lenders like to see a mix of credit types.");
                                Pause();
                                break;

                            case 6:
                                Console.WriteLine("6. Only open accounts when needed.");
                                Console.WriteLine("Tip: Too many unnecessary loans or cards can hurt your score.");
                                Console.WriteLine("Example: Don't open a store card just for a one-time discount.");
                                Pause();
                                break;

                            case 7:
                                Console.WriteLine("7. Become (or use) an authorized user.");
                                Console.WriteLine("Tip: Being added to someone else's good credit account helps build your credit.");
                                Console.WriteLine("Example: Your parents add you to their credit card, boosting your score.");
                                Pause();
                                break;

                            case 8:
                                Console.WriteLine("8. Help your child build credit early.");
                                Console.WriteLine("Tip: Add your child as an authorized user so they start building credit young.");
                                Console.WriteLine("Example: As soon as they have an SSN, you can add them to your card.");
                                Pause();
                                break;

                            case 9:
                                Console.WriteLine("9. Keep balances under 10% of your limit.");
                                Console.WriteLine("Tip: This shows strong financial discipline.");
                                Console.WriteLine("Example: On a $2,000 limit, keep your balance under $200.");
                                Pause();
                                break;

                            case 10:
                                Console.WriteLine("10. Small habits add up over time.");
                                Console.WriteLine("Tip: Credit improvement takes months or years; stay consistent.");
                                Console.WriteLine("Example: Every on-time payment slowly improves your score.");
                                Pause();
                                break;

                            case 0:
                                stayInCreditMenu = false;
                                break;

                            default:
                                Console.WriteLine("Invalid input! Try again.");
                                Pause();
                                break;
                        }
                    }
                }

                // =======================
                // Option 3: Future Home
                // =======================
                else if (mainOption == 3)
                {
                    bool stayInHomeMenu = true;

                    while (stayInHomeMenu)
                    {
                        Console.Clear();
                        Console.WriteLine("\n--- Future Home Advice ---");
                        Console.WriteLine("1) How to save up for a home");
                        Console.WriteLine("2) Things to consider before buying");
                        Console.WriteLine("0) Return to Main Menu");
                        Console.Write("Choose (0-2): ");

                        choice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        switch (choice)
                        {
                            case 1:
                                // Submenu: how to save for a home
                                bool stayInSaveMenu = true;
                                while (stayInSaveMenu)
                                {
                                    Console.Clear();
                                    Console.WriteLine("--- Ideas on how to save money for a house ---");
                                    Console.WriteLine("1) Know your timeline and how much you need");
                                    Console.WriteLine("2) Understand how down payments work");
                                    Console.WriteLine("3) Expect house prices to rise over time");
                                    Console.WriteLine("4) Expect repair costs");
                                    Console.WriteLine("5) Closing costs add up");
                                    Console.WriteLine("6) Start a savings plan based on your goal");
                                    Console.WriteLine("7) Use a high-yield savings account");
                                    Console.WriteLine("8) Use a CD for higher fixed interest");
                                    Console.WriteLine("0) Back");
                                    Console.Write("\nChoose (0-8): ");

                                    int saveChoice = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();

                                    switch (saveChoice)
                                    {
                                        case 1:
                                            Console.WriteLine("1. Know your timeline and how much you need");
                                            Console.WriteLine("Tip: Decide when you want to buy a house and estimate all costs.");
                                            Console.WriteLine("Example: A house worth $800,000 in 5 years might need around $56,000 for a down payment, repairs, and closing costs.");
                                            Pause();
                                            break;

                                        case 2:
                                            Console.WriteLine("2. Understand how down payments work");
                                            Console.WriteLine("Tip: Down payments are usually 3%-20% of the home price.");
                                            Console.WriteLine("Example: On a $600,000 house, 3% down is $18,000.");
                                            Pause();
                                            break;

                                        case 3:
                                            Console.WriteLine("3. Expect house prices to rise over time");
                                            Console.WriteLine("Tip: Homes get more expensive in most areas, so save extra.");
                                            Pause();
                                            break;

                                        case 4:
                                            Console.WriteLine("4. Expect repair costs");
                                            Console.WriteLine("Tip: No house is perfect, budget for repairs.");
                                            Console.WriteLine("Example: Plan for at least about 1% of the house price for repairs.");
                                            Pause();
                                            break;

                                        case 5:
                                            Console.WriteLine("5. Closing costs add up");
                                            Console.WriteLine("Tip: Closing costs are usually 2%-5% of the home price.");
                                            Console.WriteLine("Example: A $600,000 home may have $12,000-$30,000 in closing costs.");
                                            Pause();
                                            break;

                                        case 6:
                                            Console.WriteLine("6. After calculating the total you need, start a savings plan");
                                            Console.WriteLine("Tip: Know your goal and break it into monthly deposits.");
                                            Console.WriteLine("Example: $56,000 over 5 years = about $933 a month.");
                                            Pause();
                                            break;

                                        case 7:
                                            Console.WriteLine("7. Use a high-yield savings account for easy access");
                                            Console.WriteLine("Tip: It grows slowly but is safe and easy to withdraw from.");
                                            Console.WriteLine("Example: Your rate may go up or down depending on the bank.");
                                            Pause();
                                            break;

                                        case 8:
                                            Console.WriteLine("8. Use a CD for higher fixed interest");
                                            Console.WriteLine("Tip: A CD pays more than a savings account but locks your money in.");
                                            Console.WriteLine("Example: A $3,000 CD at 4% for 3 years earns money, but withdrawing early costs a penalty.");
                                            Pause();
                                            break;

                                        case 0:
                                            stayInSaveMenu = false;
                                            break;

                                        default:
                                            Console.WriteLine("Invalid input! Try again.");
                                            Pause();
                                            break;
                                    }
                                }
                                break;

                            case 2:
                                // Submenu: things to consider before buying
                                bool stayInConsiderMenu = true;
                                while (stayInConsiderMenu)
                                {
                                    Console.Clear();
                                    Console.WriteLine("--- Things to consider before buying a house ---");
                                    Console.WriteLine("1) Don't expect the seller to be fully honest");
                                    Console.WriteLine("2) Hire your own inspector");
                                    Console.WriteLine("3) Research repair costs after inspection");
                                    Console.WriteLine("4) Check the location carefully");
                                    Console.WriteLine("5) Look for future development plans");
                                    Console.WriteLine("6) Make sure the house fits your budget");
                                    Console.WriteLine("7) Consider monthly maintenance and HOA fees");
                                    Console.WriteLine("8) Keep an emergency fund even after buying");
                                    Console.WriteLine("9) Check the age and condition of the roof");
                                    Console.WriteLine("10) Consider the long-term value of the area");
                                    Console.WriteLine("11) Know your total monthly cost, not just the mortgage");
                                    Console.WriteLine("12) Don't make emotional decisions");
                                    Console.WriteLine("13) Think long-term before committing");
                                    Console.WriteLine("0) Back");
                                    Console.Write("\nChoose (0-13): ");

                                    int considerChoice = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();

                                    switch (considerChoice)
                                    {
                                        case 1:
                                            Console.WriteLine("1. Don't expect the seller to be fully honest");
                                            Console.WriteLine("Tip: Sellers won't always share all problems with the house.");
                                            Console.WriteLine("Example: They may downplay leaks, termites, or old systems.");
                                            Pause();
                                            break;

                                        case 2:
                                            Console.WriteLine("2. Hire your own inspector");
                                            Console.WriteLine("Tip: Pick an inspector yourself, not one recommended by the agent.");
                                            Console.WriteLine("Example: This avoids the inspector working in the agent's favor.");
                                            Pause();
                                            break;

                                        case 3:
                                            Console.WriteLine("3. Research repair costs after inspection");
                                            Console.WriteLine("Tip: Know how much repairs cost before committing.");
                                            Console.WriteLine("Example: A roof fix can cost more than you expect.");
                                            Pause();
                                            break;

                                        case 4:
                                            Console.WriteLine("4. Check the location carefully");
                                            Console.WriteLine("Tip: Location impacts value and lifestyle.");
                                            Console.WriteLine("Example: Look at commute time, crime rate, school district, stores nearby.");
                                            Pause();
                                            break;

                                        case 5:
                                            Console.WriteLine("5. Look for future development plans");
                                            Console.WriteLine("Tip: New construction can raise or lower the value of the home.");
                                            Console.WriteLine("Example: A new shopping center may boost value; a new freeway might increase noise.");
                                            Pause();
                                            break;

                                        case 6:
                                            Console.WriteLine("6. Make sure the house fits your budget");
                                            Console.WriteLine("Tip: Don't stretch too thin.");
                                            Console.WriteLine("Example: After the mortgage payment, you should still have enough for food, bills, and saving.");
                                            Pause();
                                            break;

                                        case 7:
                                            Console.WriteLine("7. Consider monthly maintenance and HOA fees");
                                            Console.WriteLine("Tip: These extra costs add up every month.");
                                            Console.WriteLine("Example: HOA may charge $200-$400 monthly.");
                                            Pause();
                                            break;

                                        case 8:
                                            Console.WriteLine("8. Keep an emergency fund even after buying");
                                            Console.WriteLine("Tip: Don't spend all your money on the house.");
                                            Console.WriteLine("Example: You still need money for car repairs, medical bills, etc.");
                                            Pause();
                                            break;

                                        case 9:
                                            Console.WriteLine("9. Check the age and condition of the roof");
                                            Console.WriteLine("Tip: Roofs are expensive and must be replaced eventually.");
                                            Console.WriteLine("Example: A full roof replacement often costs over $15,000.");
                                            Pause();
                                            break;

                                        case 10:
                                            Console.WriteLine("10. Consider the long-term value of the area");
                                            Console.WriteLine("Tip: Location, schools, and nearby development all affect future value.");
                                            Console.WriteLine("Example: Homes near good schools tend to rise in value.");
                                            Pause();
                                            break;

                                        case 11:
                                            Console.WriteLine("11. Know your total monthly cost, not just the mortgage");
                                            Console.WriteLine("Tip: There are many extra expenses involved in owning a home.");
                                            Console.WriteLine("Example: Taxes, insurance, utilities, repairs.");
                                            Pause();
                                            break;

                                        case 12:
                                            Console.WriteLine("12. Don't make emotional decisions");
                                            Console.WriteLine("Tip: Evaluate the home logically, not just emotionally.");
                                            Console.WriteLine("Example: A pretty kitchen shouldn't make you ignore outdated wiring.");
                                            Pause();
                                            break;

                                        case 13:
                                            Console.WriteLine("13. Think long-term before committing");
                                            Console.WriteLine("Tip: A house is a long financial responsibility.");
                                            Console.WriteLine("Example: Will the location still work for you in 5-10 years?");
                                            Pause();
                                            break;

                                        case 0:
                                            stayInConsiderMenu = false;
                                            break;

                                        default:
                                            Console.WriteLine("Invalid input! Try again.");
                                            Pause();
                                            break;
                                    }
                                }
                                break;

                            case 0:
                                stayInHomeMenu = false;
                                break;

                            default:
                                Console.WriteLine("Invalid input! Try again.");
                                Pause();
                                break;
                        }
                    }
                }

                // ==========================
                // Option 4: Budget Calculator
                // ==========================
                else if (mainOption == 4)
                {
                    Console.Write("Enter your monthly after-tax income: $");
                    income = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter your rent/mortgage: $");
                    rent = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter other necessities (bills, groceries, gas, etc.): $");
                    necessities = Convert.ToDouble(Console.ReadLine());

                    totalNeeds = rent + necessities;

                    Console.WriteLine("\nChoose a Budget Plan:");
                    Console.WriteLine("1. 70 / 20 / 10 (Needs / Wants / Savings)");
                    Console.WriteLine("2. 80 / 10 / 10 (Needs / Wants / Savings)");
                    Console.Write("Select a plan (1 or 2): ");
                    plan = Convert.ToInt32(Console.ReadLine());

                    if (plan == 1)
                    {
                        needsPercent = 0.70;
                        wantsPercent = 0.20;
                        savingsPercent = 0.10;
                    }
                    else
                    {
                        needsPercent = 0.80;
                        wantsPercent = 0.10;
                        savingsPercent = 0.10;
                    }

                    needsTotal = income * needsPercent;
                    wantsTotal = income * wantsPercent;
                    savingsTotal = income * savingsPercent;

                    Console.WriteLine("\n------ Budget Summary ------");
                    Console.WriteLine($"Monthly Income: ${income}");
                    Console.WriteLine($"Needs ({needsPercent * 100}%): ${needsTotal}");
                    Console.WriteLine($"Wants ({wantsPercent * 100}%): ${wantsTotal}");
                    Console.WriteLine($"Savings ({savingsPercent * 100}%): ${savingsTotal}");
                    Console.WriteLine($"\nYour current essential expenses: ${totalNeeds}");

                    if (totalNeeds > needsTotal)
                        Console.WriteLine("Warning: Your needs exceed the recommended budget.");
                    else
                        Console.WriteLine("Good job! Your needs fit the budget plan.");

                    Pause();
                }

                // =======================
                // EXIT PROGRAM
                // =======================
                else if (mainOption == 5)
                {
                    Console.WriteLine("Thank you for using Financial Helper!");
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid option! Try again.");
                    Pause();
                }
            }
        }

        static void Pause()
        {
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }
    }
}
