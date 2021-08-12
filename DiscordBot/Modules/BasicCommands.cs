﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Net;
using Discord.Commands;
using Discord;
using System.Windows.Forms;

namespace DiscordBot.Modules
{
    public class BasicCommands : ModuleBase<SocketCommandContext>
    {
        [Command("hi")]
        public async Task hi()
        {

            // initialize empty string builder for reply
            var sb = new StringBuilder();

            // get user info from the Context
            var user = Context.User;

            // build out the reply
            sb.AppendLine($"Hello {user}!");

            // send simple string reply
            await ReplyAsync(sb.ToString());
        }
        [Command("math")]
        public async Task Add(int numberOne, int numberTwo, char operation)
        {
            switch(operation)
            {
                case '+':
                    {
                        await ReplyAsync($"{numberOne} + {numberTwo} = {(numberOne + numberTwo).ToString()}");
                        break;
                    }
                case '-':
                    {
                        await ReplyAsync($"{numberOne} - {numberTwo} = {(numberOne-numberTwo).ToString()}");
                    break;
                    }
                case '/':
                    {
                        await ReplyAsync($"{numberOne} / {numberTwo} = {(numberOne / numberTwo).ToString()}");
                        break;
                    }
                case '*':
                    {
                        await ReplyAsync($"{numberOne} * {numberTwo} = {(numberOne * numberTwo).ToString()}");
                        break;
                    }
                case '%':
                    {
                        await ReplyAsync($"{numberOne} % {numberTwo} = {(numberOne % numberTwo).ToString()}");
                        break;
                    }
                default:
                    {
                        await ReplyAsync("You must enter the values in this order - +math num1 num2 arithmeticoperator");
                        break;
                    }
            }

        }


    }
}