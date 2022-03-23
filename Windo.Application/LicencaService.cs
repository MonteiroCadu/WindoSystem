using System;
using System.Text;
using Windo.Application.Contratos;
using Windo.Persistence.Contratos;

namespace Windo.Application;

public class LicencaService : ILicencaService{
    private readonly ILicencaPersist licencaPersist;

    public LicencaService(ILicencaPersist licencaPersist)
    {
        this.licencaPersist = licencaPersist;
    }
   

    public string getStringEncryptLicenca(string id, string broker)
    {
        //string[] teste = { "64321190", "Xp Investimentos","","","","","" };
        //7E846B635877D53A2BD51B320D9453407E8F4C22C104E1E9481783A50FADD162            

        string[] licencaStr = { id, broker, "", "", "", "", "" };
        string retonro = "";

        // WinDoLibController.SetPositionString(ref licencaStr);
        this.licencaPersist.getLicencaArryString(ref licencaStr);

        if (licencaStr != null)
        {

            retonro = licencaStr[2];
            retonro = retonro + "," + licencaStr[3];
            retonro = retonro + "," + licencaStr[4];
            retonro = retonro + "," + licencaStr[5];
            retonro = retonro + "," + licencaStr[6];


        }
        var s = retonro;

        var s1 = s.Aggregate("", (h, c) => h + ((int)c).ToString("x4"));          // left padded with 0       "0030d835dfcfd835dfdad835dfe5d835dff0d835dffb"
        var s2 = s.Aggregate("", (h, c) => h + string.Format("{0,4:x}", (int)c)); // left padded with space   "  30d835dfcfd835dfdad835dfe5d835dff0d835dffb"

        var sL = BitConverter.ToString(Encoding.Unicode.GetBytes(s)).Replace("-", "");       // Little Endian "300035D8CFDF35D8DADF35D8E5DF35D8F0DF35D8FBDF"
        var sB = BitConverter.ToString(Encoding.BigEndianUnicode.GetBytes(s)).Replace("-", ""); // Big Endian "0030D835DFCFD835DFDAD835DFE5D835DFF0D835DFFB"

        // no encodding "300035D8CFDF35D8DADF35D8E5DF35D8F0DF35D8FBDF"
        byte[] b = new byte[s.Length * sizeof(char)];
        Buffer.BlockCopy(s.ToCharArray(), 0, b, 0, b.Length);
        var sb = BitConverter.ToString(b).Replace("-", "");

        
        return sb;
        
    }


}
