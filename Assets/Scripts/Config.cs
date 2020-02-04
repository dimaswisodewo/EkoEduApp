using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config : MonoBehaviour
{
    public const string sceneMenu = "MainScene";
    public const string sceneLogin = "LoginScene";
    public const string sceneMateri = "MateriScene";
    public const string scenePertumbuhan = "MateriPertumbuhanScene";
    public const string scenePertumbuhan1 = "MateriPertumbuhan1Scene";
    public const string scenePertumbuhan2 = "MateriPertumbuhan2Scene";
    public const string scenePembangunan = "MateriPembangunanScene";
    public const string scenePembangunan1 = "MateriPembangunan1Scene";
    public const string scenePembangunan2 = "MateriPembangunan2Scene";
    public const string scenePembangunan3 = "MateriPembangunan3Scene";
    public const string scenePembangunan4 = "MateriPembangunan4Scene";
    public const string sceneProfil = "ProfileScene";
    public const string sceneContohSoal = "ContohSoalScene";
    public const string scenePeta = "PetaScene";
    public const string sceneKuis = "KuisScene";
    public const string sceneDaftarPustaka = "DaftarPustakaScene";
    public const string sceneSilabusAplikasi = "SilabusAplikasiScene";

    public const float timerQuiz = 30;

    public const string ACEH = "Aceh";
    public const string SUMATERA_UTARA = "Sumatera Utara";
    public const string SUMATERA_BARAT = "Sumatera Barat";
    public const string RIAU = "Riau";
    public const string KEPULAUAN_RIAU = "Kepulauan Riau";
    public const string JAMBI = "Jambi";
    public const string BENGKULU = "Bengkulu";
    public const string SUMATERA_SELATAN = "Sumatera Selatan";
    public const string BANGKA_BELITUNG = "Bangka Belitung";
    public const string LAMPUNG = "Lampung";
    public const string BANTEN = "Banten";
    public const string JAWA_BARAT = "Jawa Barat";
    public const string DKI_JAKARTA = "DKI Jakarta";
    public const string JAWA_TENGAH = "Jawa Tengah";
    public const string DI_YOGYAKARTA = "Daerah Istimewa Yogyakarta";
    public const string JAWA_TIMUR = "Jawa TImur";
    public const string BALI = "Bali";
    public const string NTB = "Nusa Tenggara Barat";
    public const string NTT = "Nusa Tenggara Timur";
    public const string KALIMANTAN_UTARA = "Kalimantan Utara";
    public const string KALIMANTAN_BARAT = "Kalimantan Barat";
    public const string KALIMANTAN_TENGAH = "Kalimantan Tengah";
    public const string KALIMANTAN_SELATAN = "Kalimantan Selatan";
    public const string KALIMANTAN_TIMUR = "Kalimantan Timur";
    public const string GORONTALO = "Gorontalo";
    public const string SULAWESI_UTARA = "Sulawesi Utara";
    public const string SULAWESI_BARAT = "Sulawesi Barat";
    public const string SULAWESI_TENGAH = "Sulawesi Tengah";
    public const string SULAWESI_SELATAN = "Sulawesi Selatan";
    public const string SULAWESI_TENGGARA = "Sulawesi Tenggara";
    public const string MALUKU_UTARA = "Maluku Utara";
    public const string MALUKU = "Maluku";
    public const string PAPUA_BARAT = "Papua Barat";
    public const string PAPUA = "Papua";
}

public class MathUtility
{
    public static int RandomizeInt(int count, List<int> listUsedValues)
    {
        int index = Random.Range(0, count);

        while (listUsedValues.Contains(index))
        {
            index = Random.Range(0, count);
        }

        listUsedValues.Add(index);
        return index;
    }

    public static int ToInteger(float inputFloat)
    {
        int outputInt = Mathf.RoundToInt(inputFloat);
        return outputInt;
    }
}

public enum SCENE
{
    MENU,
    LOGIN,
    MATERI,
    MATERI_PERTUMBUHAN,
    MATERI_PEMBANGUNAN,
    MATERI_PEMBANGUNAN_1,
    MATERI_PEMBANGUNAN_2,
    MATERI_PEMBANGUNAN_3,
    MATERI_PEMBANGUNAN_4,
    MATERI_PERTUMBUHAN_1,
    MATERI_PERTUMBUHAN_2,
    PROFIL,
    CONTOH_SOAL,
    PETA,
    KUIS,
    DAFTAR_PUSTAKA,
    SILABUS
}

public enum BUTTON_COLOR
{
    WHITE,
    GREEN,
    RED,
    YELLOW
}

public enum SOUND
{
    SELECT,
    CORRECT,
    WRONG,
    CLAP
}

public enum ORIENTATION
{
    PORTRAIT,
    LANDSCAPE
}

public enum PROVINSI
{
    ACEH,
    SUMATERA_UTARA,
    SUMATERA_BARAT,
    RIAU,
    KEPULAUAN_RIAU,
    JAMBI,
    BENGKULU,
    SUMATERA_SELATAN,
    BANGKA_BELITUNG,
    LAMPUNG,
    BANTEN,
    JAWA_BARAT,
    JAKARTA,
    JAWA_TENGAH,
    YOGYAKARTA,
    JAWA_TIMUR,
    BALI,
    NTB,
    NTT,
    KALIMANTAN_UTARA,
    KALIMANTAN_BARAT,
    KALIMANTAN_TENGAH,
    KALIMANTAN_SELATAN,
    KALIMANTAN_TIMUR,
    GORONTALO,
    SULAWESI_UTARA,
    SULAWESI_BARAT,
    SULAWESI_TENGAH,
    SULAWESI_SELATAN,
    SULAWESI_TENGGARA,
    MALUKU_UTARA,
    MALUKU,
    PAPUA_BARAT,
    PAPUA
}