using OpenUtau.Api;
using OpenUtau.Core.G2p;

namespace OpenUtau.Core.DiffSinger
{
    [Phonemizer("DiffSinger English TGM Phonemizer", "DIFFS EN TGM", language: "EN")]
    public class DiffSingerEnglishTGMPhonemizer : DiffSingerG2pPhonemizer
    {
        protected override string GetDictionaryName()=>"dsdict-en-tgm.yaml";
        protected override IG2p LoadBaseG2p() => new tgmG2p();
        protected override string[] GetBaseG2pVowels() => new string[] {
            "aa", "ae", "ah", "ao", "aw", "ax", "ay", "eh", "er", 
            "ey", "ih", "iy", "ow", "oy", "uh", "uw"
        };

        protected override string[] GetBaseG2pConsonants() => new string[] {
            "b", "ch", "d", "dh", "dr", "dx", "f", "g", "hh", "jh", "k", "l", "m", "n", 
            "ng", "p", "r", "s", "sh", "t", "th", "tr", "v", "w", "y", "z", "zh"
        };
    }
}
