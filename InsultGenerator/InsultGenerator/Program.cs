using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Insult mean = new Insult();
            mean.Welcome();
            mean.Selection();
            List<string> insults = new List<string>();

            insults.Add("artless");
            insults.Add("bawdy");
            insults.Add("beslubbering");
            insults.Add("bootless");
            insults.Add("churlish");
            insults.Add("cockered");
            insults.Add("clouted");
            insults.Add("craven");
            insults.Add("currish");
            insults.Add("dankish");
            insults.Add("dissembling");
            insults.Add("droning");
            insults.Add("errant");
            insults.Add("fawning");
            insults.Add("fobbing");
            insults.Add("froward");
            insults.Add("frothy");
            insults.Add("gleeking");
            insults.Add("goatish");
            insults.Add("gorebellied");
            insults.Add("impertinent");
            insults.Add("infectious");
            insults.Add("jarring");
            insults.Add("loggerheaded");
            insults.Add("lumpish");
            insults.Add("mammering");
            insults.Add("mangled");
            insults.Add("mewling");
            insults.Add("paunchy");
            insults.Add("pribbling");
            insults.Add("puking");
            insults.Add("puny");
            insults.Add("qualling");
            insults.Add("rank");
            insults.Add("reeky");
            insults.Add("roguish");
            insults.Add("ruttish");
            insults.Add("saucy");
            insults.Add("spleeny");
            insults.Add("spongy");
            insults.Add("surly");
            insults.Add("tottering");
            insults.Add("unmuzzled");
            insults.Add("vain");
            insults.Add("venomed");
            insults.Add("villainous");
            insults.Add("warped");
            insults.Add("wayward");
            insults.Add("weedy");
            insults.Add("yeasty");

            List<string> insults2 = new List<string>();
            insults2.Add("base-court");
            insults2.Add("bat-fowling");
            insults2.Add("beetle-headed");
            insults2.Add("boil-brained");
            insults2.Add("clapper-clawed");
            insults2.Add("clay-brained");
            insults2.Add("common-kissing");
            insults2.Add("crook-pated");
            insults2.Add("dismal-dreaming");
            insults2.Add("dizzy-eyed");
            insults2.Add("doghearted");
            insults2.Add("dread-bolted");
            insults2.Add("earth-vexing");
            insults2.Add("elf-skinned");
            insults2.Add("fat-kidneyed");
            insults2.Add("fen-sucked");
            insults2.Add("flap-mouthed");
            insults2.Add("fly-bitten");
            insults2.Add("folly-fallen");
            insults2.Add("fool-born");
            insults2.Add("full-gorged");
            insults2.Add("guts-griping");
            insults2.Add("half-faced");
            insults2.Add("hasty-witted");
            insults2.Add("hege-born");
            insults2.Add("hell-hated");
            insults2.Add("idle-headed");
            insults2.Add("ill-breeding");
            insults2.Add("ill-nurtured");
            insults2.Add("knotty-pated");
            insults2.Add("milk-livered");
            insults2.Add("motley-minded");
            insults2.Add("onion-eyed");
            insults2.Add("plume-plucked");
            insults2.Add("pottle-deep");
            insults2.Add("pox-marked");
            insults2.Add("reeling-ripe");
            insults2.Add("rough-hewn");
            insults2.Add("rude-growing");
            insults2.Add("rump-fed");
            insults2.Add("shard-borne");
            insults2.Add("sheep-biting");
            insults2.Add("spur-galled");
            insults2.Add("swag-bellied");
            insults2.Add("tardy-gaited");
            insults2.Add("tickle-brained");
            insults2.Add("toad-spotted");
            insults2.Add("unchin-snouted");
            insults2.Add("weather-bitten");

            List<string> insults3 = new List<string>();
            insults3.Add("apple-john");
            insults3.Add("baggage");
            insults3.Add("barnacle");
            insults3.Add("bladder");
            insults3.Add("boar-pig");
            insults3.Add("bugbear");
            insults3.Add("bum-bailey");
            insults3.Add("canker-blossom");
            insults3.Add("clack-dish");
            insults3.Add("clotpole");
            insults3.Add("coxcomb");
            insults3.Add("codpiece");
            insults3.Add("death-token");
            insults3.Add("dewberry");
            insults3.Add("flap-dragon");
            insults3.Add("flax-wench");
            insults3.Add("flirt-gill");
            insults3.Add("foot-licker");
            insults3.Add("giglet");
            insults3.Add("gudgeon");
            insults3.Add("haggard");
            insults3.Add("harpy");
            insults3.Add("hedge-pie");
            insults3.Add("horn-beast");
            insults3.Add("hugger-mugger");
            insults3.Add("joithead");
            insults3.Add("lewdster");
            insults3.Add("lout");
            insults3.Add("maggot-pie");
            insults3.Add("malt-worm");
            insults3.Add("mammet");
            insults3.Add("measle");
            insults3.Add("minnow");
            insults3.Add("miscreant");
            insults3.Add("moldwarp");
            insults3.Add("mumble-news");
            insults3.Add("nut-hook");
            insults3.Add("pigeon-egg");
            insults3.Add("pignut");
            insults3.Add("puttock");
            insults3.Add("pumpion");
            insults3.Add("ratsbane");
            insults3.Add("scut");
            insults3.Add("skainsmate");
            insults3.Add("strumpet");
            insults3.Add("varlot");
            insults3.Add("vassal");
            insults3.Add("whey-face");
            insults3.Add("wagtail");










            string input = Console.ReadLine();
            while (input != "exit")
            {
                if (input == "exit")
                {
                    break;
                }

                else if (input == "insult")
                {
                    Random rnd = new Random();
                    Random rnd2 = new Random();
                    Random rnd3 = new Random();
                    int count = insults.Count();
                    int count2 = insults2.Count();
                    int count3 = insults3.Count();
                    int ranNum = rnd.Next(0, count);
                    int ranNum2 = rnd2.Next(0, count2);
                    int ranNum3 = rnd3.Next(0, count3);
                    string ranValue = insults.ElementAt(ranNum);
                    string ranValue2 = insults2.ElementAt(ranNum2);
                    string ranValue3 = insults3.ElementAt(ranNum3);
                    Console.WriteLine("You are a " + ranValue + " " + ranValue2 + " " + ranValue3 + "!");
                    mean.Selection();
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("please make a valid selection");
                    mean.Selection();
                    input = Console.ReadLine();
                }
                if (input == "exit")
                {
                    break;
                }
            }
        }
    }
}