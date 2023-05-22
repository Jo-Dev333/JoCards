using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using JoCards.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using ModdingUtils.Utils;


namespace JoCards
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class JoCards : BaseUnityPlugin
    {
        private const string ModId = "com.JoCards.Id";
        private const string ModName = "JoCards";
        public const string Version = "1.0.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "JO";


        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            CustomCard.BuildCard<Evade>();
            CustomCard.BuildCard<Sniper>();
            CustomCard.BuildCard<grenadeLauncher>();
            CustomCard.BuildCard<Trickster>();
            instance = this;
        }
        
        public static JoCards instance { get; private set; }
    }
    
}
