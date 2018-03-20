using System;
using Creighton_Model_App.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Creighton_Model_App.Data;

namespace Creighton_Model_App.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            ApplicationDbContext context =
                applicationBuilder.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            {
                context.AddRange
                (
                    new Sticker
                    {
                        StickerColor = "Red",
                    },
                    new Sticker
                    {
                        StickerColor = "Green",
                    },
                    new Sticker
                    {
                        StickerColor = "White",
                    },
                    new Sticker
                    {
                        StickerColor = "Yellow Baby",
                    },
                    new Sticker
                    {
                        StickerColor = "Green Baby",
                    },
                    new Description
                    {
                        Observation = "Dry",
                    },
                    new Description
                    {
                        Observation = "Damp without lubrication",
                    },
                    new Description
                    {
                        Observation = "Wet without lubrication",
                    },
                    new Description
                    {
                        Observation = "Shiny without lubrication",
                    },
                    new Description
                    {
                        Observation = "Sticky-B",
                    },
                    new Description
                    {
                        Observation = "Sticky-C",
                    },
                    new Description
                    {
                        Observation = "Sticky-C/K",
                    },
                    new Description
                    {
                        Observation = "Sticky-G",
                    },
                    new Description
                    {
                        Observation = "Sticky-K",
                    },
                    new Description
                    {
                        Observation = "Sticky-L",
                    },
                    new Description
                    {
                        Observation = "Sticky-P",
                    },
                    new Description
                    {
                        Observation = "Sticky-Y",
                    },
                    new Description
                    {
                        Observation = "Tacky-B",
                    },
                    new Description
                    {
                        Observation = "Tacky-C/K",
                    },
                    new Description
                    {
                        Observation = "Tacky-G",
                    },
                    new Description
                    {
                        Observation = "Tacky-K",
                    },
                    new Description
                    {
                        Observation = "Tacky-L",
                    },
                    new Description
                    {
                        Observation = "Tacky-P",
                    },
                    new Description
                    {
                        Observation = "Tacky-Y",
                    },
                    new Description
                    {
                        Observation = "Stretchy-B",
                    },
                    new Description
                    {
                        Observation = "Stretchy-C",
                    },
                    new Description
                    {
                        Observation = "Stretchy-C/K",
                    },
                    new Description
                    {
                        Observation = "Stretchy-G",
                    },
                    new Description
                    {
                        Observation = "Stretchy-K",
                    },
                    new Description
                    {
                        Observation = "Stretchy-L",
                    },
                    new Description
                    {
                        Observation = "Stretchy-P",
                    },
                    new Description
                    {
                        Observation = "Stretchy-Y",
                    },
                    new Description
                    {
                        Observation = "Damp with Lubrication",
                    },
                    new Description
                    {
                        Observation = "Shiny with lubrication",
                    },
                    new Description
                    {
                        Observation = "Wet with lubrication",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
