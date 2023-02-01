using Elskom.Generic.Libs;

namespace Drugovich.CrossCutting.Help
{
    public static class Crypt
    {
        public static string Encrypt(string item, string key)
        {
            BlowFish blowfish = new BlowFish(key);
            return blowfish.EncryptECB(item);
        }

        public static string Decrypt(string item, string Key)
        {
            BlowFish blowfish = new BlowFish(Key);
            return blowfish.DecryptECB(item);
        }
    }
}
