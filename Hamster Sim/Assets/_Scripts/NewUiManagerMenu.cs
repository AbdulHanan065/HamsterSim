using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewUiManagerMenu : MonoBehaviour
{

    #region Singleton
    private static NewUiManagerMenu _Instance;
    public static NewUiManagerMenu Instance
    {
        get
        {

            if (!_Instance) _Instance = FindObjectOfType<NewUiManagerMenu>();

            return _Instance;
        }
    }

    private void Awake()
    {
        if (!_Instance) _Instance = this;


    }
    #endregion
    #region Variables


    [Header("<--- Meta Data --->")]
    public PlayerData _PlayerData;
    public BowlData _BowlData;
    public HouseData _HouseData;
    public FoodData _FoodData;
    public FeederData _FeederData;
    public WheelData _WheelData;
    public CageData _CageData;
    public BGData _BGData;

    [Header("<--- Buttons --->")]

    public GameObject ShopButton;
    [Header("<--- Worlds --->")]
    public GameObject WorldDropDown;
    public TextMeshProUGUI WorldNoText;
    public int WorldNo;

    [Header("<--- Panels --->")]

    public GameObject ShopMainPanel;
    public GameObject PlayerPanel;
    public GameObject BowlPanel;
    public GameObject FoodPanel;
    public GameObject WheelPanel;
    public GameObject HosuePanel;
    public GameObject FeederPanel;
    public GameObject CagePanel;
    public GameObject BGPanel;
    public GameObject[] ShopPanels;
    public int ShopButtonsIndex;
    public GameObject NotEnoughCashPanel;
    public GameObject LimitReachedPanel;

  
    [Header("<--- Economy --->")]

    public bool giveMoney;
    public int ToffeeCoins;
    public int DiamondCoins;
    public TextMeshProUGUI ToffeeCoinsText;
    public TextMeshProUGUI DiamondCoinsText;

    [Header("<--- Player Stats --->")]
    public int PlayerIndex;
   
    public GameObject[] Players;
    public Image PlayerImage;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI Health;
    public TextMeshProUGUI Damage;
    public TextMeshProUGUI Defence;
    public TextMeshProUGUI Speed;
    public TextMeshProUGUI Discription;
    public TextMeshProUGUI PriceText;
    public Image PlayerLock;
    public GameObject BuyToffeeBtn;
    public GameObject BuyDiamondBtn;
    public GameObject SelectBtn;
    public GameObject PlayerNextBtn;
    public GameObject PlayerPreviousBtn;
    public Image HealthSlider;
    public Image DamageSlider;
    public Image DefenceSlider;
    public Image SpeedSlider;
    public GameObject CongratsPlayerPanel;
    public Image CongratsPlayerItemImage;
    public TextMeshProUGUI CongratsPlayerItemName;

    [Header("<--- Bowl Stats --->")]
    public int BowlIndex;
    public GameObject[] Bowls;
    public Image BowlImage;
    public Image BowlLockImage;
    public TextMeshProUGUI BowlnameText;
    public TextMeshProUGUI BowlPriceText;
    public TextMeshProUGUI BowlDiscription;
    public GameObject BuyBowlToffeeBtn;
    public GameObject BuyBowlDiamondBtn;
    public GameObject SelectBowlBtn;
    public GameObject BowlNextBtn;
    public GameObject BowlPreviousBtn;

    public GameObject CongratsBowlPanel;
    public Image CongratsBowlItemImage;
    public TextMeshProUGUI CongratsBowlItemName;

    [Header("<--- Food Stats --->")]
    public int FoodIndex;
    public GameObject[] Foods;
    public Image FoodImage;
    public Image FoodLockImage;
    public TextMeshProUGUI FoodnameText;
    public TextMeshProUGUI FoodPriceText;
    public TextMeshProUGUI FoodDiscription;
    public GameObject BuyFoodToffeeBtn;
    public GameObject BuyFoodDiamondBtn;
    public GameObject SelectFoodBtn;
    public GameObject FoodNextBtn;
    public GameObject FoodPreviousBtn;

    public GameObject CongratsFoodPanel;
    public Image CongratsFoodItemImage;
    public TextMeshProUGUI CongratsFoodItemName;

    [Header("<--- House Stats --->")]
    public int HouseIndex;
    public GameObject[] Houses;
    public Image HouseImage;
    public Image HouseLockImage;
    public TextMeshProUGUI HousenameText;
    public TextMeshProUGUI HousePriceText;
    public TextMeshProUGUI HouseDiscription;
    public GameObject BuyHouseToffeeBtn;
    public GameObject BuyHouseDiamondBtn;
    public GameObject SelectHouseBtn;
    public GameObject HouseNextBtn;
    public GameObject HousePreviousBtn;

    public GameObject CongratsHousePanel;
    public Image CongratsHouseItemImage;
    public TextMeshProUGUI CongratsHouseItemName;
    [Header("<--- Feeder Stats --->")]
    public int FeederIndex;
    public GameObject[] Feeders;
    public Image FeederImage;
    public Image FeederLockImage;
    public TextMeshProUGUI FeedernameText;
    public TextMeshProUGUI FeederPriceText;
    public TextMeshProUGUI FeederDiscription;
    public GameObject BuyFeederToffeeBtn;
    public GameObject BuyFeederDiamondBtn;
    public GameObject SelectFeederBtn;
    public GameObject FeederNextBtn;
    public GameObject FeederPreviousBtn;

    public GameObject CongratsFeederPanel;
    public Image CongratsFedderItemImage;
    public TextMeshProUGUI CongratsFeederItemName;
    [Header("<--- Toys Stats --->")]
    public int ToyIndex;
    public GameObject[] Toys;
    public Image ToyImage;
    public Image ToyLockImage;
    public TextMeshProUGUI ToynameText;
    public TextMeshProUGUI ToyPriceText;
    public TextMeshProUGUI ToyDiscription;
    public GameObject BuyToyToffeeBtn;
    public GameObject BuyToyDiamondBtn;
    public GameObject SelectToyBtn;
    public GameObject ToyNextBtn;
    public GameObject ToyPreviousBtn;

    public GameObject CongratsToyPanel;
    public Image CongratsToyItemImage;
    public TextMeshProUGUI CongratsToyItemName;
    [Header("<--- Cage Stats --->")]
    public int CageIndex;
    public GameObject[] Cages;
    public Image CageImage;
    public Image CageLockImage;
    public TextMeshProUGUI CagenameText;
    public TextMeshProUGUI CagePriceText;
    public TextMeshProUGUI CageDiscription;
    public GameObject BuyCageToffeeBtn;
    public GameObject BuyCageDiamondBtn;
    public GameObject SelectCageBtn;
    public GameObject CageNextBtn;
    public GameObject CagePreviousBtn;
    public GameObject CongratsCagePanel;
    public Image CongratsCageItemImage;
    public TextMeshProUGUI CongratsCageItemName;

    [Header("<--- BG Stats --->")]
    public int BGIndex;
    public GameObject[] BGs;
    public Image BGImage;
    public Image BGLockImage;
    public TextMeshProUGUI BGnameText;
    public TextMeshProUGUI BGPriceText;
    public TextMeshProUGUI BGDiscription;
    public GameObject BuyBGToffeeBtn;
    public GameObject BuyBGDiamondBtn;
    public GameObject SelectBGBtn;
    public GameObject BGNextBtn;
    public GameObject BGPreviousBtn;

    public GameObject CongratsBgPanel;
    public Image CongratsBgItemImage;
    public TextMeshProUGUI CongratsBgItemName;

    #endregion

    void Start()
    {
        if (giveMoney)
        {
            PlayerPrefs.SetInt("coins", 300);
            PlayerPrefs.SetInt("diamonds", 100);
        }

        //PlayerPrefs.DeleteAll();

        if (!PlayerPrefs.HasKey("coins"))
        {
            PlayerPrefs.SetInt("players" + 0, 1);
            PlayerPrefs.SetInt("bowl" + 0, 1);
            PlayerPrefs.SetInt("house" + 0, 1);
            PlayerPrefs.SetInt("food" + 0, 1);
            PlayerPrefs.SetInt("toy" + 0, 1);
            PlayerPrefs.SetInt("feeder" + 0, 1);
            PlayerPrefs.SetInt("cage" + 0, 1);
            PlayerPrefs.SetInt("bg" + 0, 1);
            PlayerPrefs.SetInt("coins", 5);
            PlayerPrefs.SetInt("diamonds", 5);

            ToffeeCoins = PlayerPrefs.GetInt("coins");
            ToffeeCoinsText.text = ToffeeCoins.ToString() + " T";
            DiamondCoins = PlayerPrefs.GetInt("diamonds");
            DiamondCoinsText.text = DiamondCoins.ToString() + " D";
            PlayerLock.gameObject.SetActive(false);
            BowlLockImage.gameObject.SetActive(false);
            CageLockImage.gameObject.SetActive(false);
            FeederLockImage.gameObject.SetActive(false);
            FoodLockImage.gameObject.SetActive(false);
            HouseLockImage.gameObject.SetActive(false);
            BGLockImage.gameObject.SetActive(false);
            ToyLockImage.gameObject.SetActive(false);
        }
        else
        {

            ToffeeCoins = PlayerPrefs.GetInt("coins");
            ToffeeCoinsText.text = ToffeeCoins.ToString() + " T";

            DiamondCoins = PlayerPrefs.GetInt("diamonds");
            DiamondCoinsText.text = DiamondCoins.ToString() + " D";

            Debug.Log("BG no :"+ PlayerPrefs.GetInt("bg_bought"));

            RenderSettings.skybox = _BGData.BG[PlayerPrefs.GetInt("bg_bought")].Mat;
            MenuSceneManager.Instance.DirectionalLight.GetComponent<Light>().color = _BGData.BG[PlayerPrefs.GetInt("bg_bought")].LightColor;
        }

        

        


    }


    public void WorldNoButton(int i)
    {
        WorldNoText.text = i.ToString();
        WorldManager.Instance.WorldIndex = i-1;

        for (int j =0; j < WorldManager.Instance._WorldData.Length; j++)
        {
            //Debug.Log(j);
            WorldManager.Instance._WorldData[j].World.SetActive(false);
        }
        WorldNo = i - 1;
        WorldManager.Instance._WorldData[i-1].World.SetActive(true);

        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");


    }


    public void ShopBtn()
    {

        PlayerPrefs.SetInt("players" + 0, 1);
        PlayerPrefs.SetInt("bowl" + 0, 1);
        PlayerPrefs.SetInt("house" + 0, 1);
        PlayerPrefs.SetInt("food" + 0, 1);
        PlayerPrefs.SetInt("feeder" + 0, 1);
        PlayerPrefs.SetInt("toy" + 0, 1);
        PlayerPrefs.SetInt("cage" + 0, 1);
        PlayerPrefs.SetInt("bg" + 0, 1);

        PlayerIndex = 0;
        BowlIndex = 0;
        FeederIndex = 0;
        FoodIndex = 0;
        HouseIndex = 0;
        CageIndex = 0;
        ToyIndex = 0;
        BGIndex = 0;
        ShopButtonsIndex = 0;

        
       

        PlayerPreviousBtn.SetActive(false);
        BowlPreviousBtn.SetActive(false);
        CagePreviousBtn.SetActive(false);
        FoodPreviousBtn.SetActive(false);
        FeederPreviousBtn.SetActive(false);
        BGPreviousBtn.SetActive(false);
        HousePreviousBtn.SetActive(false);
        ToyPreviousBtn.SetActive(false);


        PlayerNextBtn.SetActive(true);
        BowlNextBtn.SetActive(true);
        CageNextBtn.SetActive(true);
        FoodNextBtn.SetActive(true);
        FeederNextBtn.SetActive(true);
        BGNextBtn.SetActive(true);
        HouseNextBtn.SetActive(true);
        ToyNextBtn.SetActive(true);



        nameText.text = _PlayerData.stats[0].Name;
        Health.text = _PlayerData.stats[0].Health.ToString();
        Damage.text = _PlayerData.stats[0].Damage.ToString();
        Defence.text = _PlayerData.stats[0].Defence.ToString();
        Speed.text = _PlayerData.stats[0].Speed.ToString();
        Discription.text = _PlayerData.stats[0].Discription;

        HealthSlider.fillAmount = _PlayerData.stats[0].Health / 100;
        DamageSlider.fillAmount = _PlayerData.stats[0].Damage / 100;
        DefenceSlider.fillAmount = _PlayerData.stats[0].Defence / 100;
        SpeedSlider.fillAmount = _PlayerData.stats[0].Speed / 100;

        PlayerImage.sprite = _PlayerData.stats[0].PlayerAvater;

        PriceText.text = _PlayerData.stats[0].Price.ToString() + " T";
        PriceText.text = "Owned";


        PlayerLock.gameObject.SetActive(false);
        BowlLockImage.gameObject.SetActive(false);
        CageLockImage.gameObject.SetActive(false);
        FeederLockImage.gameObject.SetActive(false);
        FoodLockImage.gameObject.SetActive(false);
        HouseLockImage.gameObject.SetActive(false);
        BGLockImage.gameObject.SetActive(false);
        ToyLockImage.gameObject.SetActive(false);


        BowlnameText.text = _BowlData.Bowl_stats[0].Name;
        BowlDiscription.text = _BowlData.Bowl_stats[0].Discription;
        BowlImage.sprite = _BowlData.Bowl_stats[0].Icon;
        BowlPriceText.text = "Owned";

        CagenameText.text = _CageData.Cage_Data[0].Name;
        CageDiscription.text = _CageData.Cage_Data[0].Discription;
        CageImage.sprite = _CageData.Cage_Data[0].Icon;
        CagePriceText.text = "Owned";

        FoodnameText.text = _FoodData.Food_stats[0].Name;
        FoodDiscription.text = _FoodData.Food_stats[0].Discription;
        FoodImage.sprite = _FoodData.Food_stats[0].Icon;
        FoodPriceText.text = "Owned";


        HousenameText.text = _HouseData.House_stats[0].Name;
        HouseDiscription.text = _HouseData.House_stats[0].Discription;
        HouseImage.sprite = _HouseData.House_stats[0].Icon;
        HousePriceText.text = "Owned";

        FoodnameText.text = _FoodData.Food_stats[0].Name;
        FoodDiscription.text = _FoodData.Food_stats[0].Discription;
        FoodImage.sprite = _FoodData.Food_stats[0].Icon;
        FoodPriceText.text = "Owned";


        ToynameText.text = _WheelData.Wheel_stats[0].Name;
        ToyDiscription.text = _WheelData.Wheel_stats[0].Discription;
        ToyImage.sprite = _WheelData.Wheel_stats[0].Icon;
        ToyPriceText.text = "Owned";

        BGnameText.text = _BGData.BG[0].Name;
        BGDiscription.text = _BGData.BG[0].Discription;
        BGImage.sprite = _BGData.BG[0].Icon;
        BGPriceText.text = "Owned";


        FeedernameText.text = _FeederData.Feeder_stats[0].Name;
        FeederDiscription.text = _FeederData.Feeder_stats[0].Discription;
        FeederImage.sprite = _FeederData.Feeder_stats[0].Icon;
        FeederPriceText.text = "Owned";

        BuyToffeeBtn.SetActive(false);
        // WatchVideoBtn.SetActive(false);
        SelectBtn.SetActive(true);
        PlayerLock.gameObject.SetActive(false);

        PlayerPanel.SetActive(true);
        BowlPanel.SetActive(false);
        FoodPanel.SetActive(false);
        WheelPanel.SetActive(false);
        HosuePanel.SetActive(false);
        BGPanel.SetActive(false);
        CagePanel.SetActive(false);
        FeederPanel.SetActive(false);



        MenuSceneManager.Instance.ShopCamera.SetActive(true);
        MenuSceneManager.Instance.TopDownCamera.SetActive(false);

        for (int i = 0; i < Players.Length; i++)
        {
            Players[i].SetActive(false);
        }
        Players[0].SetActive(true);

        for (int i = 0; i < Bowls.Length; i++)
        {
            Bowls[i].SetActive(false);
        }
        Bowls[0].SetActive(true);

        for (int i = 0; i < Houses.Length; i++)
        {
            Houses[i].SetActive(false);
        }
        Houses[0].SetActive(true);

        for (int i = 0; i < Cages.Length; i++)
        {
            Cages[i].SetActive(false);
        }
        Cages[0].SetActive(true);

        for (int i = 0; i < Toys.Length; i++)
        {
            Toys[i].SetActive(false);
        }
        Toys[0].SetActive(true);

        for (int i = 0; i < BGs.Length; i++)
        {
            BGs[i].SetActive(false);
        }
        BGs[0].SetActive(true);

        for (int i = 0; i < Feeders.Length; i++)
        {
            Feeders[i].SetActive(false);
        }
        Feeders[0].SetActive(true);

        for (int i = 0; i < Foods.Length; i++)
        {
            Foods[i].SetActive(false);
        }
        Foods[0].SetActive(true);

        FindObjectOfType<AudioManager>().PlaySound("menubuttons");
        
        
    }


    public void ShopBackBtn()
    {
        PlayerPanel.SetActive(false);
        BowlPanel.SetActive(false);
        FoodPanel.SetActive(false);
        WheelPanel.SetActive(false);
        HosuePanel.SetActive(false);
        BGPanel.SetActive(false);
        CagePanel.SetActive(false);
        FeederPanel.SetActive(false);

        MenuSceneManager.Instance.ShopCamera.SetActive(false);
        MenuSceneManager.Instance.TopDownCamera.SetActive(true);

        FindObjectOfType<AudioManager>().PlaySound("menubuttons");
    }


    public void ShopButtons(int j)
    {

        for (int i = 0; i < ShopPanels.Length; i++)
        {

            ShopPanels[i].SetActive(false);
        }

        ShopPanels[j].SetActive(true);

         ShopButtonsIndex =j;
    }


    public void NotEnoughCashOkButton()
    {

        ShopPanels[ShopButtonsIndex].SetActive(true);
    }

    public void PlayerBtn()
    {
        PlayerPanel.SetActive(true);

        BowlPanel.SetActive(false);
        FoodPanel.SetActive(false);
        WheelPanel.SetActive(false);
        HosuePanel.SetActive(false);
        BGPanel.SetActive(false);
        CagePanel.SetActive(false);
        FeederPanel.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");
    }

    public void BowlBtn()
    {
        PlayerPanel.SetActive(false);

        BowlPanel.SetActive(true);
        FoodPanel.SetActive(false);
        WheelPanel.SetActive(false);
        HosuePanel.SetActive(false);
        BGPanel.SetActive(false);
        CagePanel.SetActive(false);
        FeederPanel.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");
    }


    public void WheelBtn()
    {
        PlayerPanel.SetActive(false);

        BowlPanel.SetActive(false);
        FoodPanel.SetActive(false);
        WheelPanel.SetActive(true);
        HosuePanel.SetActive(false);
        BGPanel.SetActive(false);
        CagePanel.SetActive(false);
        FeederPanel.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");
    }

    public void HouseBtn()
    {
        PlayerPanel.SetActive(false);

        BowlPanel.SetActive(false);
        FoodPanel.SetActive(false);
        WheelPanel.SetActive(false);
        HosuePanel.SetActive(true);
        BGPanel.SetActive(false);
        CagePanel.SetActive(false);
        FeederPanel.SetActive(false);

        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }

    public void FoodBtn()
    {
        PlayerPanel.SetActive(false);

        BowlPanel.SetActive(false);
        FoodPanel.SetActive(true);
        WheelPanel.SetActive(false);
        HosuePanel.SetActive(false);
        BGPanel.SetActive(false);
        CagePanel.SetActive(false);
        FeederPanel.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");
    }

    public void CageBtn()
    {
        PlayerPanel.SetActive(false);

        BowlPanel.SetActive(false);
        FoodPanel.SetActive(false);
        WheelPanel.SetActive(false);
        HosuePanel.SetActive(false);
        BGPanel.SetActive(false);
        CagePanel.SetActive(true);
        FeederPanel.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");
    }

    public void BGBtn()
    {
        PlayerPanel.SetActive(false);

        BowlPanel.SetActive(false);
        FoodPanel.SetActive(false);
        WheelPanel.SetActive(false);
        HosuePanel.SetActive(false);
        BGPanel.SetActive(true);
        CagePanel.SetActive(false);
        FeederPanel.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");
    }

    public void FeederBtn()
    {
        PlayerPanel.SetActive(false);

        BowlPanel.SetActive(false);
        FoodPanel.SetActive(false);
        WheelPanel.SetActive(false);
        HosuePanel.SetActive(false);
        BGPanel.SetActive(false);
        CagePanel.SetActive(false);
        FeederPanel.SetActive(true);
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");
    }


    #region PlayerData
    public void NexPlayertbutton_F()
    {
        PlayerIndex++;
        nameText.text = _PlayerData.stats[PlayerIndex].Name;
        Health.text = _PlayerData.stats[PlayerIndex].Health.ToString();
        Damage.text = _PlayerData.stats[PlayerIndex].Damage.ToString();
        Defence.text = _PlayerData.stats[PlayerIndex].Defence.ToString();
        Speed.text = _PlayerData.stats[PlayerIndex].Speed.ToString();
        Discription.text = _PlayerData.stats[PlayerIndex].Discription;

        HealthSlider.fillAmount = _PlayerData.stats[PlayerIndex].Health / 100;
        DamageSlider.fillAmount = _PlayerData.stats[PlayerIndex].Damage / 100;
        DefenceSlider.fillAmount = _PlayerData.stats[PlayerIndex].Defence / 100;
        SpeedSlider.fillAmount = _PlayerData.stats[PlayerIndex].Speed / 100;

        PlayerImage.sprite = _PlayerData.stats[PlayerIndex].PlayerAvater;

       
        //DiamondPriceText.text = _PlayerData.stats[PlayerIndex].Diamonds.ToString() + " D";
        PriceText.text = _PlayerData.stats[PlayerIndex].Price.ToString() + " T";

        for (int i = 0; i <= Players.Length - 1; i++)
        {
            Players[i].SetActive(false);
        }
        Players[PlayerIndex].SetActive(true);

        if (PlayerIndex >= 0)
        {
            PlayerPreviousBtn.SetActive(true);
        }
        if (PlayerIndex == Players.Length - 1)
        {
            PlayerNextBtn.SetActive(false);
        }
        if (PlayerPrefs.GetInt("players" + PlayerIndex) == 1)
        {
            PriceText.text = "Owned";
            BuyToffeeBtn.SetActive(false);
            BuyDiamondBtn.SetActive(false);
            PlayerLock.gameObject.SetActive(false);
            SelectBtn.SetActive(true);

        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (PlayerIndex == 1 || PlayerIndex == 2 || PlayerIndex == 3)
            {
                BuyToffeeBtn.SetActive(true);
                BuyDiamondBtn.SetActive(false);
                PriceText.text = _PlayerData.stats[PlayerIndex].Price.ToString() + " T";
            }
            else if (PlayerIndex == 4 || PlayerIndex == 5 || PlayerIndex == 6)
            {
                BuyDiamondBtn.SetActive(true);
                BuyToffeeBtn.SetActive(false);
                PriceText.text = _PlayerData.stats[PlayerIndex].Price.ToString() + " D";
            }

            SelectBtn.SetActive(false);
            PlayerLock.gameObject.SetActive(true);
        }

        FindObjectOfType<AudioManager>().PlaySound("next");

        Players[PlayerIndex].GetComponent<DOTweenAnimation>().DORestartById("player");

    }


    public void PreviousPlayer_F()
    {
        PlayerIndex--;
        nameText.text = _PlayerData.stats[PlayerIndex].Name;
        Health.text = _PlayerData.stats[PlayerIndex].Health.ToString();
        Damage.text = _PlayerData.stats[PlayerIndex].Damage.ToString();
        Defence.text = _PlayerData.stats[PlayerIndex].Defence.ToString();
        Speed.text = _PlayerData.stats[PlayerIndex].Speed.ToString();
        Discription.text = _PlayerData.stats[PlayerIndex].Discription;

        HealthSlider.fillAmount = _PlayerData.stats[PlayerIndex].Health / 100;
        DamageSlider.fillAmount = _PlayerData.stats[PlayerIndex].Damage / 100;
        DefenceSlider.fillAmount = _PlayerData.stats[PlayerIndex].Defence / 100;
        SpeedSlider.fillAmount = _PlayerData.stats[PlayerIndex].Speed / 100;

        PlayerImage.sprite = _PlayerData.stats[PlayerIndex].PlayerAvater;


        //DiamondPriceText.text = _PlayerData.stats[PlayerIndex].Diamonds.ToString() + " D";
        PriceText.text = _PlayerData.stats[PlayerIndex].Price.ToString() + " T";
        for (int i = 0; i <= Players.Length - 1; i++)
        {
            Players[i].SetActive(false);
        }
        Players[PlayerIndex].SetActive(true);

        if (PlayerIndex <= Players.Length)
        {
            PlayerNextBtn.SetActive(true);
        }
        if (PlayerIndex == 0)
        {
            PlayerPreviousBtn.SetActive(false);
            BuyToffeeBtn.SetActive(false);
            BuyDiamondBtn.SetActive(false);
            PlayerLock.gameObject.SetActive(false);
            SelectBtn.SetActive(true);
            PriceText.text = "Owned";
        }
        if (PlayerPrefs.GetInt("players" + PlayerIndex) == 1)
        {
            PriceText.text = "Owned";
            BuyToffeeBtn.SetActive(false);
            BuyDiamondBtn.SetActive(false);
            PlayerLock.gameObject.SetActive(false);
            SelectBtn.SetActive(true);

        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (PlayerIndex == 1 || PlayerIndex == 2 || PlayerIndex == 3)
            {
                BuyToffeeBtn.SetActive(true);
                BuyDiamondBtn.SetActive(false);
                PriceText.text = _PlayerData.stats[PlayerIndex].Price.ToString() + " T";
            }
            else if (PlayerIndex == 4 || PlayerIndex == 5 || PlayerIndex == 6)
            {
                BuyDiamondBtn.SetActive(true);
                BuyToffeeBtn.SetActive(false);
                PriceText.text = _PlayerData.stats[PlayerIndex].Price.ToString() + " D";
            }

            SelectBtn.SetActive(false);
            PlayerLock.gameObject.SetActive(true);
        }
        FindObjectOfType<AudioManager>().PlaySound("next");
        Players[PlayerIndex].GetComponent<DOTweenAnimation>().DORestartById("player");
    }




    public void BuyPlayerBtn()
    {
        if (PlayerPrefs.GetInt("players" + PlayerIndex) == 0)
        {

            if (ToffeeCoins >= _PlayerData.stats[PlayerIndex].Price && WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].TotalPlayerCount < 10)
            {
                if (PlayerIndex == 1 || PlayerIndex == 2 || PlayerIndex == 3)
                {
                    PlayerPrefs.SetInt("coins", ToffeeCoins - (_PlayerData.stats[PlayerIndex].Price));
                    ToffeeCoins = PlayerPrefs.GetInt("coins");
                    ToffeeCoinsText.text = PlayerPrefs.GetInt("coins").ToString() + " T";

                    PlayerLock.gameObject.SetActive(false);
                    BuyToffeeBtn.SetActive(false);
                    BuyDiamondBtn.SetActive(false);
                    //WatchVideoBtn.SetActive(false);
                    SelectBtn.SetActive(true);
                    CongratsPlayer();
                    PlayerPrefs.SetInt("players" + PlayerIndex, 1);
                    PlayerPrefs.SetInt("player_bought", PlayerIndex);
                }

               
            }
          


            else 
            {
                if (WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].TotalPlayerCount >= 10)
                {
                    LimitReachedPanel.SetActive(true);
                    ShopPanels[ShopButtonsIndex].SetActive(false);
                }
                else
                {
                    NotEnoughCashPanel.SetActive(true);
                    ShopPanels[ShopButtonsIndex].SetActive(false);
                }
               
            }

        }

      
        else if (PlayerPrefs.GetInt("players" + PlayerIndex) == 1)
          
        {
          PlayerPrefs.SetInt("player_bought", PlayerIndex);
        }
        AudioManager.instance.PlaySound("buybutton");

    }
    public void BuyDiamondPlayerBtn()
    {
        if (PlayerPrefs.GetInt("players" + PlayerIndex) == 0)
        {



            if (DiamondCoins >= _PlayerData.stats[PlayerIndex].Price && WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].TotalPlayerCount < 10)
            {

                if (PlayerIndex == 4 || PlayerIndex == 5 || PlayerIndex == 6)
                {

                    PlayerPrefs.SetInt("diamonds", DiamondCoins - (_PlayerData.stats[PlayerIndex].Price));
                    DiamondCoins = PlayerPrefs.GetInt("diamonds");
                    DiamondCoinsText.text = PlayerPrefs.GetInt("diamonds").ToString() + " D";

                    PlayerLock.gameObject.SetActive(false);
                    BuyToffeeBtn.SetActive(false);
                    BuyDiamondBtn.SetActive(false);
                    //WatchVideoBtn.SetActive(false);
                    SelectBtn.SetActive(true);
                    CongratsPlayer();
                    PlayerPrefs.SetInt("players" + PlayerIndex, 1);
                    PlayerPrefs.SetInt("player_bought", PlayerIndex);
                }


            }

            else
            {
                if(WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].TotalPlayerCount >= 10)
                {
                    LimitReachedPanel.SetActive(true);
                    ShopPanels[ShopButtonsIndex].SetActive(false);
                   
                }
                else
                {
                    NotEnoughCashPanel.SetActive(true);
                    ShopPanels[ShopButtonsIndex].SetActive(false);
                }
               
               
            }

        }


        else if (PlayerPrefs.GetInt("players" + PlayerIndex) == 1)

        {
            PlayerPrefs.SetInt("player_bought", PlayerIndex);
        }
        AudioManager.instance.PlaySound("shopbuttons");

    }


    void CongratsPlayer()
    {
        CongratsPlayerPanel.SetActive(true);
        CongratsPlayerItemImage.sprite = _PlayerData.stats[PlayerIndex].PlayerAvater;
        CongratsPlayerItemName.text = _PlayerData.stats[PlayerIndex].Name;

        MenuSceneManager.Instance.ShopCamera.SetActive(false);
        MenuSceneManager.Instance.TopDownCamera.SetActive(true);



        for (int i = 0; i < Players.Length; i++)
        {
            Players[i].SetActive(false);
        }
       
        AudioManager.instance.PlaySound("congrats");
    }


    public void SelectPlayer()
    {

        if (WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].TotalPlayerCount < 10)
        {
            PlayerPrefs.SetInt("players" + PlayerIndex, 0);

            CongratsPlayerPanel.SetActive(false);
            PlayerPanel.SetActive(false);
            ShopMainPanel.SetActive(false);
            ShopButton.SetActive(true);
            for (int i = 0; i < Players.Length; i++)
            {
                Players[i].SetActive(true);
            }

            MenuSceneManager.Instance.ShopCamera.SetActive(false);
            MenuSceneManager.Instance.TopDownCamera.SetActive(true);


            WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[PlayerIndex].Players[WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[PlayerIndex].CurrentPlayerCount].SetActive(true);
            WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[PlayerIndex].CurrentPlayerCount++;
            PlayerPrefs.SetInt("hamster" + PlayerIndex + WorldManager.Instance.WorldIndex, WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[PlayerIndex].CurrentPlayerCount);


            WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].TotalPlayerCount++;
            PlayerPrefs.SetInt("TotalPlayerCount" + WorldManager.Instance.WorldIndex, WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].TotalPlayerCount);
            Debug.Log("TotalPlayerCount : " + PlayerPrefs.GetInt("TotalPlayerCount" + WorldManager.Instance.WorldIndex));

            FindObjectOfType<AudioManager>().PlaySound("shopbuttons");
        }
        else 
        {

            LimitReachedPanel.SetActive(true);
            ShopPanels[ShopButtonsIndex].SetActive(false);
        }

    }


    #endregion

    #region BowlData
    public void NextBowlbutton_F()
    {
        BowlIndex++;
        BowlnameText.text = _BowlData.Bowl_stats[BowlIndex].Name;
      
        BowlDiscription.text = _BowlData.Bowl_stats[BowlIndex].Discription;

        

        BowlImage.sprite = _BowlData.Bowl_stats[BowlIndex].Icon;


        //DiamondPriceText.text = _PlayerData.stats[PlayerIndex].Diamonds.ToString() + " D";
        BowlPriceText.text = _BowlData.Bowl_stats[BowlIndex].price.ToString() + " T";

        for (int i = 0; i <= Bowls.Length - 1; i++)
        {
            Bowls[i].SetActive(false);
        }
        Bowls[BowlIndex].SetActive(true);

        if (BowlIndex >= 0)
        {
            BowlPreviousBtn.SetActive(true);
        }
        if (BowlIndex == Bowls.Length - 1)
        {
            BowlNextBtn.SetActive(false);
        }
        if (PlayerPrefs.GetInt("bowl" + BowlIndex) == 1)
        {
            BowlPriceText.text = "Owned";
            BuyBowlToffeeBtn.SetActive(false);
            BuyBowlDiamondBtn.SetActive(false);
            BowlLockImage.gameObject.SetActive(false);
            SelectBowlBtn.SetActive(true);

        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (BowlIndex == 1 || BowlIndex == 2 || BowlIndex == 3)
            {
                BuyBowlToffeeBtn.SetActive(true);
                BuyBowlDiamondBtn.SetActive(false);
                BowlPriceText.text = _BowlData.Bowl_stats[BowlIndex].price.ToString() + " T";
            }
            else if (BowlIndex == 4 || BowlIndex == 5 || BowlIndex == 6)
            {
                BuyBowlDiamondBtn.SetActive(true);
                BuyBowlToffeeBtn.SetActive(false);
                BowlPriceText.text = _BowlData.Bowl_stats[BowlIndex].price.ToString() + " D";
            }

            SelectBowlBtn.SetActive(false);
            BowlLockImage.gameObject.SetActive(true);
        }

        FindObjectOfType<AudioManager>().PlaySound("next");

        Bowls[BowlIndex].GetComponent<DOTweenAnimation>().DORestartById("bowl");

    }


    public void PreviousBowl_F()
    {
        BowlIndex--;
        BowlnameText.text = _BowlData.Bowl_stats[BowlIndex].Name;
       
        BowlDiscription.text = _BowlData.Bowl_stats[BowlIndex].Discription;

       

        BowlImage.sprite = _BowlData.Bowl_stats[BowlIndex].Icon;


        //DiamondPriceText.text = _PlayerData.stats[PlayerIndex].Diamonds.ToString() + " D";
        BowlPriceText.text = _BowlData.Bowl_stats[BowlIndex].price.ToString() + " T";
        for (int i = 0; i <= Bowls.Length - 1; i++)
        {
            Bowls[i].SetActive(false);
        }
        Bowls[BowlIndex].SetActive(true);

        if (BowlIndex <= Bowls.Length)
        {
            BowlNextBtn.SetActive(true);
        }
        if (BowlIndex == 0)
        {
            BowlPreviousBtn.SetActive(false);
            BuyBowlToffeeBtn.SetActive(false);
            BuyBowlDiamondBtn.SetActive(false);
            BowlLockImage.gameObject.SetActive(false);
            SelectBowlBtn.SetActive(true);
            BowlPriceText.text = "Owned";
        }
        if (PlayerPrefs.GetInt("bowl" + BowlIndex) == 1)
        {
            BowlPriceText.text = "Owned";
            BuyBowlToffeeBtn.SetActive(false);
            BuyBowlDiamondBtn.SetActive(false);
            BowlLockImage.gameObject.SetActive(false);
            SelectBowlBtn.SetActive(true);

        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (BowlIndex == 1 || BowlIndex == 2 || BowlIndex == 3)
            {
                BuyBowlToffeeBtn.SetActive(true);
                BuyBowlDiamondBtn.SetActive(false);
                BowlPriceText.text = _BowlData.Bowl_stats[BowlIndex].price.ToString() + " T";
            }
            else if (BowlIndex == 4 || BowlIndex == 5 || BowlIndex == 6)
            {
                BuyBowlDiamondBtn.SetActive(true);
                BuyBowlToffeeBtn.SetActive(false);
                BowlPriceText.text = _BowlData.Bowl_stats[BowlIndex].price.ToString() + " D";
            }

            SelectBowlBtn.SetActive(false);
            BowlLockImage.gameObject.SetActive(true);
        }
        FindObjectOfType<AudioManager>().PlaySound("next");
        Bowls[BowlIndex].GetComponent<DOTweenAnimation>().DORestartById("bowl");
    }

    public void BuyBowlBtn()
    {
        if (PlayerPrefs.GetInt("bowl" + BowlIndex) == 0)
        {

           

            if (ToffeeCoins >= _BowlData.Bowl_stats[BowlIndex].price)
            {
                if (BowlIndex == 1 || BowlIndex == 2 || BowlIndex == 3)
                {
                    PlayerPrefs.SetInt("coins", ToffeeCoins - (_BowlData.Bowl_stats[BowlIndex].price));
                    ToffeeCoins = PlayerPrefs.GetInt("coins");
                    ToffeeCoinsText.text = PlayerPrefs.GetInt("coins").ToString() + " T";
                    BowlLockImage.gameObject.SetActive(false);
                    BuyBowlToffeeBtn.SetActive(false);
                    BuyBowlDiamondBtn.SetActive(false);
                    CongratsBowl();
                    //WatchVideoBtn.SetActive(false);
                    SelectBowlBtn.SetActive(true);
                    PlayerPrefs.SetInt("bowl" + BowlIndex, 1);
                    PlayerPrefs.SetInt("bowl_bought", BowlIndex);
                }
            }
          


           else 
            {
                ShopPanels[ShopButtonsIndex].SetActive(false);
                NotEnoughCashPanel.SetActive(true);
            }
        }
       

        if (PlayerPrefs.GetInt("bowl" + BowlIndex) == 1)
        {


            PlayerPrefs.SetInt("bowl_bought", BowlIndex);
        }
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }

    public void BuyDiamondBowlBtn()
    {
        if (PlayerPrefs.GetInt("bowl" + BowlIndex) == 0)
        {



            if (DiamondCoins >= _BowlData.Bowl_stats[BowlIndex].Diamondprice)
            {
                if (BowlIndex == 4 || BowlIndex == 5 || BowlIndex == 6)
                {

                    PlayerPrefs.SetInt("diamonds", DiamondCoins - (_BowlData.Bowl_stats[BowlIndex].Diamondprice));
                    DiamondCoins = PlayerPrefs.GetInt("diamonds");
                    DiamondCoinsText.text = PlayerPrefs.GetInt("diamonds").ToString() + " D";
                    BowlLockImage.gameObject.SetActive(false);
                    BuyBowlToffeeBtn.SetActive(false);
                    BuyBowlDiamondBtn.SetActive(false);
                    CongratsBowl();
                    //WatchVideoBtn.SetActive(false);
                    SelectBowlBtn.SetActive(true);
                    PlayerPrefs.SetInt("bowl" + BowlIndex, 1);
                    PlayerPrefs.SetInt("bowl_bought", BowlIndex);
                }
            }

            else { 
                ShopPanels[ShopButtonsIndex].SetActive(false);
                NotEnoughCashPanel.SetActive(true);
            }
        }


        if (PlayerPrefs.GetInt("bowl" + BowlIndex) == 1)
        {


            PlayerPrefs.SetInt("bowl_bought", BowlIndex);
        }
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }


    void CongratsBowl()
    {
        CongratsBowlPanel.SetActive(true);
        CongratsBowlItemImage.sprite = _BowlData.Bowl_stats[BowlIndex].Icon;
        CongratsBowlItemName.text = _BowlData.Bowl_stats[BowlIndex].Name;
        MenuSceneManager.Instance.ShopCamera.SetActive(false);
        MenuSceneManager.Instance.TopDownCamera.SetActive(true);
        for (int i = 0; i < Bowls.Length; i++)
        {
            Bowls[i].SetActive(false);
        }
        
        AudioManager.instance.PlaySound("congrats");
    }

    public void SelectBowl()
    {


        PlayerPrefs.SetInt("bowl" + BowlIndex, 0);

        CongratsBowlPanel.SetActive(false);
        BowlPanel.SetActive(false);
        ShopMainPanel.SetActive(false);
        ShopButton.SetActive(true);
        for (int i = 0; i < Bowls.Length; i++)
        {
            Bowls[i].SetActive(true);
        }
        ShopButtonsIndex = 0;

        MenuSceneManager.Instance.ShopCamera.SetActive(false);
        MenuSceneManager.Instance.TopDownCamera.SetActive(true);

        //Instantiate(_PlayerData.stats[PlayerIndex].HamsterPrefab, MenuSceneManager.Instance.PlayersSpwanPoint[PlayerIndex].transform.position, MenuSceneManager.Instance.PlayersSpwanPoint[PlayerIndex].transform.rotation);
        //PlayerPrefs.SetInt("hamster" + PlayerIndex, HamsterCount[PlayerIndex]++);
        //Debug.Log(PlayerPrefs.GetInt("hamster" + PlayerIndex));

        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");
    }

    #endregion

    #region FoodData
    public void NextFoodbutton_F()
    {
        FoodIndex++;
        FoodnameText.text = _FoodData.Food_stats[FoodIndex].Name;

        FoodDiscription.text = _FoodData.Food_stats[FoodIndex].Discription;



        FoodImage.sprite = _FoodData.Food_stats[FoodIndex].Icon;


        //DiamondPriceText.text = _PlayerData.stats[PlayerIndex].Diamonds.ToString() + " D";
        FoodPriceText.text = _FoodData.Food_stats[FoodIndex].price.ToString() + " T";

        for (int i = 0; i <= Foods.Length - 1; i++)
        {
            Foods[i].SetActive(false);
        }
        Foods[FoodIndex].SetActive(true);

        if (FoodIndex >= 0)
        {
            FoodPreviousBtn.SetActive(true);
        }
        if (FoodIndex == Bowls.Length - 1)
        {
            FoodNextBtn.SetActive(false);
        }
        if (PlayerPrefs.GetInt("food" + FoodIndex) == 1)
        {
            FoodPriceText.text = "Owned";
            BuyFoodToffeeBtn.SetActive(false);
            BuyFoodDiamondBtn.SetActive(false);
            FoodLockImage.gameObject.SetActive(false);
            SelectFoodBtn.SetActive(true);

        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (FoodIndex == 1 || FoodIndex == 2 || FoodIndex == 3)
            {
                BuyFoodToffeeBtn.SetActive(true);
                BuyFoodDiamondBtn.SetActive(false);
                FoodPriceText.text = _FoodData.Food_stats[FoodIndex].price.ToString() + " T";
            }
            else if (FoodIndex == 4 || FoodIndex == 5 || FoodIndex == 6)
            {
                BuyFoodDiamondBtn.SetActive(true);
                BuyFoodToffeeBtn.SetActive(false);
                FoodPriceText.text = _FoodData.Food_stats[FoodIndex].price.ToString() + " D";
            }

            SelectFoodBtn.SetActive(false);
            FoodLockImage.gameObject.SetActive(true);
        }

        FindObjectOfType<AudioManager>().PlaySound("next");

        Foods[FoodIndex].GetComponent<DOTweenAnimation>().DORestartById("food");

    }


    public void PreviousFood_F()
    {
        FoodIndex--;
        FoodnameText.text = _FoodData.Food_stats[FoodIndex].Name;

        FoodDiscription.text = _FoodData.Food_stats[FoodIndex].Discription;



        FoodImage.sprite = _FoodData.Food_stats[FoodIndex].Icon;


        
        FoodPriceText.text = _FoodData.Food_stats[FoodIndex].price.ToString() + " T";
        for (int i = 0; i <= Bowls.Length - 1; i++)
        {
            Foods[i].SetActive(false);
        }
        Foods[FoodIndex].SetActive(true);

        if (FoodIndex <= Bowls.Length)
        {
            FoodNextBtn.SetActive(true);
        }
        if (FoodIndex == 0)
        {
            FoodPreviousBtn.SetActive(false);
            BuyFoodToffeeBtn.SetActive(false);
            BuyFoodDiamondBtn.SetActive(false);
            FoodLockImage.gameObject.SetActive(false);
            SelectFoodBtn.SetActive(true);
            FoodPriceText.text = "Owned";
        }
        if (PlayerPrefs.GetInt("food" + FoodIndex) == 1)
        {
            FoodPriceText.text = "Owned";
            BuyFoodToffeeBtn.SetActive(false);
            BuyFoodDiamondBtn.SetActive(false);
            FoodLockImage.gameObject.SetActive(false);
            SelectFoodBtn.SetActive(true);

        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (FoodIndex == 1 || FoodIndex == 2 || FoodIndex == 3)
            {
                BuyFoodToffeeBtn.SetActive(true);
                BuyFoodDiamondBtn.SetActive(false);
                FoodPriceText.text = _FoodData.Food_stats[FoodIndex].price.ToString() + " T";
            }
            else if (FoodIndex == 4 || FoodIndex == 5 || FoodIndex == 6)
            {
                BuyFoodDiamondBtn.SetActive(true);
                BuyFoodToffeeBtn.SetActive(false);
                FoodPriceText.text = _FoodData.Food_stats[FoodIndex].price.ToString() + " D";
            }

            SelectFoodBtn.SetActive(false);
            FoodLockImage.gameObject.SetActive(true);
        }
        FindObjectOfType<AudioManager>().PlaySound("next");
        Foods[FoodIndex].GetComponent<DOTweenAnimation>().DORestartById("food");
    }

    public void BuyFoodBtn()
    {
        if (PlayerPrefs.GetInt("food" + FoodIndex) == 0)
        {

            if (ToffeeCoins >= _FoodData.Food_stats[FoodIndex].price)
            {
                if (FoodIndex == 1 || FoodIndex == 2 || FoodIndex == 3)
                {
                    PlayerPrefs.SetInt("coins", ToffeeCoins - (_FoodData.Food_stats[FoodIndex].price));
                    ToffeeCoins = PlayerPrefs.GetInt("coins");
                    ToffeeCoinsText.text = PlayerPrefs.GetInt("coins").ToString() + " T";

                    FoodLockImage.gameObject.SetActive(false);
                    BuyFoodToffeeBtn.SetActive(false);
                    BuyFoodDiamondBtn.SetActive(false);
                    CongratsFood();
                    //WatchVideoBtn.SetActive(false);
                    SelectFoodBtn.SetActive(true);
                    PlayerPrefs.SetInt("food" + FoodIndex, 1);
                    PlayerPrefs.SetInt("food_bought", FoodIndex);
                }

            }
              
            

            else
            {
                ShopPanels[ShopButtonsIndex].SetActive(false);
                NotEnoughCashPanel.SetActive(true);
            }
        }

        else if (PlayerPrefs.GetInt("food" + FoodIndex) == 1)
        {


            PlayerPrefs.SetInt("food_bought", FoodIndex);
        }
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }


    public void BuyDiamondFoodBtn()
    {
        if (PlayerPrefs.GetInt("food" + FoodIndex) == 0)
        {


            if (DiamondCoins >= _FoodData.Food_stats[FoodIndex].Diamondprice)
            {
                if (FoodIndex == 4 || FoodIndex == 5 || FoodIndex == 6)
                {

                    PlayerPrefs.SetInt("diamonds", DiamondCoins - (_FoodData.Food_stats[FoodIndex].Diamondprice));
                    DiamondCoins = PlayerPrefs.GetInt("diamonds");
                    DiamondCoinsText.text = PlayerPrefs.GetInt("diamonds").ToString() + " D";

                    FoodLockImage.gameObject.SetActive(false);
                    BuyFoodToffeeBtn.SetActive(false);
                    BuyFoodDiamondBtn.SetActive(false);
                    CongratsFood();
                    //WatchVideoBtn.SetActive(false);
                    SelectFoodBtn.SetActive(true);
                    PlayerPrefs.SetInt("food" + FoodIndex, 1);
                    PlayerPrefs.SetInt("food_bought", FoodIndex);
                }
            }



            else
            {
                ShopPanels[ShopButtonsIndex].SetActive(false);
                NotEnoughCashPanel.SetActive(true);
            }
        }

        else if (PlayerPrefs.GetInt("food" + FoodIndex) == 1)
        {


            PlayerPrefs.SetInt("food_bought", FoodIndex);
        }
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }

    void CongratsFood()
    {
        CongratsFoodPanel.SetActive(true);
        CongratsFoodItemImage.sprite = _FoodData.Food_stats[FoodIndex].Icon;
        CongratsFoodItemName.text = _FoodData.Food_stats[FoodIndex].Name;

        for (int i = 0; i < Foods.Length; i++)
        {
            Foods[i].SetActive(false);
        }
        
        AudioManager.instance.PlaySound("congrats");
    }


    public void SelectFood()
    {


        PlayerPrefs.SetInt("food" + FoodIndex, 0);

        CongratsFoodPanel.SetActive(false);
        FoodPanel.SetActive(false);
        ShopMainPanel.SetActive(false);
        ShopButton.SetActive(true);
        MenuSceneManager.Instance.ShopCamera.SetActive(false);
        MenuSceneManager.Instance.TopDownCamera.SetActive(true);
        for (int i = 0; i < Foods.Length; i++)
        {
            Foods[i].SetActive(true);
        }
        ShopButtonsIndex = 0;

        MenuSceneManager.Instance.ShopCamera.SetActive(false);
        MenuSceneManager.Instance.TopDownCamera.SetActive(true);

        //Instantiate(_PlayerData.stats[PlayerIndex].HamsterPrefab, MenuSceneManager.Instance.PlayersSpwanPoint[PlayerIndex].transform.position, MenuSceneManager.Instance.PlayersSpwanPoint[PlayerIndex].transform.rotation);
        //PlayerPrefs.SetInt("hamster" + PlayerIndex, HamsterCount[PlayerIndex]++);
        //Debug.Log(PlayerPrefs.GetInt("hamster" + PlayerIndex));
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }

    #endregion

    #region HouseData
    public void NextHousebutton_F()
    {
        HouseIndex++;
        HousenameText.text = _HouseData.House_stats[HouseIndex].Name;

        HouseDiscription.text = _HouseData.House_stats[HouseIndex].Discription;



        HouseImage.sprite = _HouseData.House_stats[HouseIndex].Icon;


        //DiamondPriceText.text = _PlayerData.stats[PlayerIndex].Diamonds.ToString() + " D";
        HousePriceText.text = _HouseData.House_stats[HouseIndex].price.ToString() + " T";

        for (int i = 0; i <= Houses.Length - 1; i++)
        {
            Houses[i].SetActive(false);
        }
        Houses[HouseIndex].SetActive(true);

        if (HouseIndex >= 0)
        {
            HousePreviousBtn.SetActive(true);
        }
        if (HouseIndex == Houses.Length - 1)
        {
            HouseNextBtn.SetActive(false);
        }
        if (PlayerPrefs.GetInt("house" + HouseIndex) == 1)
        {
            HousePriceText.text = "Owned";
            BuyHouseToffeeBtn.SetActive(false);
            BuyHouseDiamondBtn.SetActive(false);
            HouseLockImage.gameObject.SetActive(false);
            SelectHouseBtn.SetActive(true);

        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (HouseIndex == 1 || HouseIndex == 2 || HouseIndex == 3 || HouseIndex == 4 || HouseIndex == 5)
            {
                BuyHouseToffeeBtn.SetActive(true);
                BuyHouseDiamondBtn.SetActive(false);
                HousePriceText.text = _HouseData.House_stats[HouseIndex].price.ToString() + " T";
            }
            else if (HouseIndex == 6 || HouseIndex == 7 || HouseIndex == 8 || HouseIndex == 9 || HouseIndex == 10)
            {
                BuyHouseDiamondBtn.SetActive(true);
                BuyHouseToffeeBtn.SetActive(false);
                HousePriceText.text = _HouseData.House_stats[HouseIndex].price.ToString() + " D";
            }

            SelectHouseBtn.SetActive(false);
            HouseLockImage.gameObject.SetActive(true);
        }

        FindObjectOfType<AudioManager>().PlaySound("next");
        Houses[HouseIndex].GetComponent<DOTweenAnimation>().DORestartById("house");


    }


    public void PreviousHouse_F()
    {
        HouseIndex--;
        HousenameText.text = _HouseData.House_stats[HouseIndex].Name;

        HouseDiscription.text = _HouseData.House_stats[HouseIndex].Discription;



        HouseImage.sprite = _HouseData.House_stats[HouseIndex].Icon;


        //DiamondPriceText.text = _PlayerData.stats[PlayerIndex].Diamonds.ToString() + " D";
        HousePriceText.text = _HouseData.House_stats[HouseIndex].price.ToString() + " T";

        for (int i = 0; i <= Houses.Length - 1; i++)
        {
            Houses[i].SetActive(false);
        }
        Houses[HouseIndex].SetActive(true);

        if (HouseIndex <= Houses.Length)
        {
            HouseNextBtn.SetActive(true);
        }
        if (HouseIndex == 0)
        {
            HousePreviousBtn.SetActive(false);
            BuyHouseToffeeBtn.SetActive(false);
            BuyHouseDiamondBtn.SetActive(false);
            HouseLockImage.gameObject.SetActive(false);
            SelectHouseBtn.SetActive(true);
            HousePriceText.text = "Owned";
        }
        if (PlayerPrefs.GetInt("house" + HouseIndex) == 1)
        {
            HousePriceText.text = "Owned";
            BuyHouseToffeeBtn.SetActive(false);
            BuyHouseDiamondBtn.SetActive(false);
            HouseLockImage.gameObject.SetActive(false);
            SelectHouseBtn.SetActive(true);

        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (HouseIndex == 1 || HouseIndex == 2 || HouseIndex == 3 || HouseIndex == 4 || HouseIndex == 5 )
            {
                BuyHouseToffeeBtn.SetActive(true);
                BuyHouseDiamondBtn.SetActive(false);
                HousePriceText.text = _HouseData.House_stats[HouseIndex].price.ToString() + " T";
            }
            else if (HouseIndex == 6 || HouseIndex == 7 || HouseIndex == 8 || HouseIndex == 9 || HouseIndex == 10)
            {
                BuyHouseDiamondBtn.SetActive(true);
                BuyHouseToffeeBtn.SetActive(false);
                HousePriceText.text = _HouseData.House_stats[HouseIndex].price.ToString() + " D";
            }

            SelectHouseBtn.SetActive(false);
            HouseLockImage.gameObject.SetActive(true);
        }
        FindObjectOfType<AudioManager>().PlaySound("next");
        Houses[HouseIndex].GetComponent<DOTweenAnimation>().DORestartById("house");

    }

    public void BuyHouseBtn()
    {
        if (PlayerPrefs.GetInt("house" + HouseIndex) == 0)
        {

            if (ToffeeCoins >= _HouseData.House_stats[HouseIndex].price)
            {
                if (HouseIndex == 1 || HouseIndex == 2 || HouseIndex == 3)
                {
                    PlayerPrefs.SetInt("coins", ToffeeCoins - (_HouseData.House_stats[HouseIndex].price));
                    ToffeeCoins = PlayerPrefs.GetInt("coins");
                    ToffeeCoinsText.text = PlayerPrefs.GetInt("coins").ToString() + " T";

                    HouseLockImage.gameObject.SetActive(false);
                    BuyHouseToffeeBtn.SetActive(false);
                    BuyHouseDiamondBtn.SetActive(false);
                    CongratsHouse();
                    //WatchVideoBtn.SetActive(false);
                    SelectHouseBtn.SetActive(true);
                    PlayerPrefs.SetInt("house" + HouseIndex, 1);
                    PlayerPrefs.SetInt("house_bought", HouseIndex);
                }
            }
                

            else
            {
                ShopPanels[ShopButtonsIndex].SetActive(false);
                NotEnoughCashPanel.SetActive(true);
            }
        }

        else if (PlayerPrefs.GetInt("house" + HouseIndex) == 1)
        {


            PlayerPrefs.SetInt("house_bought", HouseIndex);
        }
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }


    public void BuyDiamondHouseBtn()
    {
        if (PlayerPrefs.GetInt("house" + HouseIndex) == 0)
        {


            if (DiamondCoins >= _HouseData.House_stats[HouseIndex].Diamondprice)
            {
                if (HouseIndex == 4 || HouseIndex == 5 || HouseIndex == 6)
                {

                    PlayerPrefs.SetInt("diamonds", DiamondCoins - (_HouseData.House_stats[HouseIndex].Diamondprice));
                    DiamondCoins = PlayerPrefs.GetInt("diamonds");
                    DiamondCoinsText.text = PlayerPrefs.GetInt("diamonds").ToString() + " D";

                    HouseLockImage.gameObject.SetActive(false);
                    BuyHouseToffeeBtn.SetActive(false);
                    BuyHouseDiamondBtn.SetActive(false);
                    CongratsHouse();
                    //WatchVideoBtn.SetActive(false);
                    SelectHouseBtn.SetActive(true);
                    PlayerPrefs.SetInt("house" + HouseIndex, 1);
                    PlayerPrefs.SetInt("house_bought", HouseIndex);
                }
            }



            else
            {
                ShopPanels[ShopButtonsIndex].SetActive(false);
                NotEnoughCashPanel.SetActive(true);
            }
        }

        else if (PlayerPrefs.GetInt("house" + HouseIndex) == 1)
        {


            PlayerPrefs.SetInt("house_bought", HouseIndex);
        }
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }



    void CongratsHouse()
    {
        CongratsHousePanel.SetActive(true);
        CongratsHouseItemImage.sprite = _HouseData.House_stats[HouseIndex].Icon;
        CongratsHouseItemName.text = _HouseData.House_stats[HouseIndex].Name;
        MenuSceneManager.Instance.ShopCamera.SetActive(false);
        MenuSceneManager.Instance.TopDownCamera.SetActive(true);
        for (int i = 0; i < Houses.Length; i++)
        {
            Houses[i].SetActive(false);
        }
        
        AudioManager.instance.PlaySound("congrats");
    }


    public void SelectHouse()
    {


        PlayerPrefs.SetInt("house" + HouseIndex, 0);

        CongratsHousePanel.SetActive(false);
        HosuePanel.SetActive(false);
        ShopMainPanel.SetActive(false);
        ShopButton.SetActive(true);
        for (int i = 0; i < Houses.Length; i++)
        {
            Houses[i].SetActive(true);
        }
        ShopButtonsIndex = 0;


        MenuSceneManager.Instance.ShopCamera.SetActive(false);
        MenuSceneManager.Instance.TopDownCamera.SetActive(true);

        //Instantiate(_PlayerData.stats[PlayerIndex].HamsterPrefab, MenuSceneManager.Instance.PlayersSpwanPoint[PlayerIndex].transform.position, MenuSceneManager.Instance.PlayersSpwanPoint[PlayerIndex].transform.rotation);
        //PlayerPrefs.SetInt("hamster" + PlayerIndex, HamsterCount[PlayerIndex]++);
        //Debug.Log(PlayerPrefs.GetInt("hamster" + PlayerIndex));
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }

    #endregion

    #region FeederData
    public void NextFeederbutton_F()
    {
        FeederIndex++;
        FeedernameText.text = _FeederData.Feeder_stats[FeederIndex].Name;

        FeederDiscription.text = _FeederData.Feeder_stats[FeederIndex].Discription;

        FeederImage.sprite = _FeederData.Feeder_stats[FeederIndex].Icon;


        //DiamondPriceText.text = _PlayerData.stats[PlayerIndex].Diamonds.ToString() + " D";
        FeederPriceText.text = _FeederData.Feeder_stats[FeederIndex].price.ToString() + " T";

        for (int i = 0; i <= Feeders.Length - 1; i++)
        {
            Feeders[i].SetActive(false);
        }
        Feeders[FeederIndex].SetActive(true);

        if (FeederIndex >= 0)
        {
            FeederPreviousBtn.SetActive(true);
        }
        if (FeederIndex == Feeders.Length - 1)
        {
            FeederNextBtn.SetActive(false);
        }
        if (PlayerPrefs.GetInt("feeder" + FeederIndex) == 1)
        {
            FeederPriceText.text = "Owned";
            BuyFeederToffeeBtn.SetActive(false);
            BuyFeederDiamondBtn.SetActive(false);
            FeederLockImage.gameObject.SetActive(false);
            SelectFeederBtn.SetActive(true);

        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (FeederIndex == 1 || FeederIndex == 2 || FeederIndex == 3)
            {
                BuyFeederToffeeBtn.SetActive(true);
                BuyFeederDiamondBtn.SetActive(false);
                FeederPriceText.text = _FeederData.Feeder_stats[FeederIndex].price.ToString() + " T";
            }
            else if (FeederIndex == 4 || FeederIndex == 5 )
            {
                BuyFeederDiamondBtn.SetActive(true);
                BuyFeederToffeeBtn.SetActive(false);
                FeederPriceText.text = _FeederData.Feeder_stats[FeederIndex].price.ToString() + " D";
            }

            SelectFeederBtn.SetActive(false);
            FeederLockImage.gameObject.SetActive(true);
        }

        FindObjectOfType<AudioManager>().PlaySound("next");

        Feeders[FeederIndex].GetComponent<DOTweenAnimation>().DORestartById("feeder");

    }


    public void PreviousFeeder_F()
    {
        FeederIndex--;
        FeedernameText.text = _FeederData.Feeder_stats[FeederIndex].Name;

        FeederDiscription.text = _FeederData.Feeder_stats[FeederIndex].Discription;



        FeederImage.sprite = _FeederData.Feeder_stats[FeederIndex].Icon;



        FeederPriceText.text = _FeederData.Feeder_stats[FeederIndex].price.ToString() + " T";
        for (int i = 0; i <= Feeders.Length - 1; i++)
        {
            Feeders[i].SetActive(false);
        }
        Feeders[FoodIndex].SetActive(true);

        if (FeederIndex <= Feeders.Length)
        {
            FeederNextBtn.SetActive(true);
        }
        if (FeederIndex == 0)
        {
            FeederPreviousBtn.SetActive(false);
            BuyFeederToffeeBtn.SetActive(false);
            BuyFeederDiamondBtn.SetActive(false);
            FeederLockImage.gameObject.SetActive(false);
            SelectFeederBtn.SetActive(true);
            FeederPriceText.text = "Owned";
        }
        if (PlayerPrefs.GetInt("feeder" + FeederIndex) == 1)
        {
            FeederPriceText.text = "Owned";
            BuyFeederToffeeBtn.SetActive(false);
            BuyFeederDiamondBtn.SetActive(false);
            FeederLockImage.gameObject.SetActive(false);
            SelectFeederBtn.SetActive(true);

        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (FeederIndex == 1 || FeederIndex == 2 || FeederIndex == 3)
            {
                BuyFeederToffeeBtn.SetActive(true);
                BuyFeederDiamondBtn.SetActive(false);
                FeederPriceText.text = _FeederData.Feeder_stats[FeederIndex].price.ToString() + " T";
            }
            else if (FeederIndex == 4 || FeederIndex == 5 )
            {
                BuyFeederDiamondBtn.SetActive(true);
                BuyFeederToffeeBtn.SetActive(false);
                FeederPriceText.text = _FeederData.Feeder_stats[FeederIndex].price.ToString() + " D";
            }

            SelectFeederBtn.SetActive(false);
            FeederLockImage.gameObject.SetActive(true);
        }
        FindObjectOfType<AudioManager>().PlaySound("next");
        Feeders[FeederIndex].GetComponent<DOTweenAnimation>().DORestartById("feeder");
    }


    public void BuyFeederBtn()
    {
        if (PlayerPrefs.GetInt("feeder" + FeederIndex) == 0)
        {

            if (ToffeeCoins >= _FeederData.Feeder_stats[FeederIndex].price)
            {
                if (FeederIndex == 1 || FeederIndex == 2 || FeederIndex == 3)
                {
                    PlayerPrefs.SetInt("coins", ToffeeCoins - (_FeederData.Feeder_stats[FeederIndex].price));
                    ToffeeCoins = PlayerPrefs.GetInt("coins");
                    ToffeeCoinsText.text = PlayerPrefs.GetInt("coins").ToString() + " T";

                    FeederLockImage.gameObject.SetActive(false);
                    BuyFeederToffeeBtn.SetActive(false);
                    BuyFeederDiamondBtn.SetActive(false);
                    CongratsFeeder();
                    //WatchVideoBtn.SetActive(false);
                    SelectFeederBtn.SetActive(true);
                    PlayerPrefs.SetInt("feeder" + FeederIndex, 1);
                    PlayerPrefs.SetInt("feeder_bought", FeederIndex);
                }

            }
                
            else
            {
                ShopPanels[ShopButtonsIndex].SetActive(false);
                NotEnoughCashPanel.SetActive(true);
            }
        }

        else if (PlayerPrefs.GetInt("feeder" + FeederIndex) == 1)
        {


            PlayerPrefs.SetInt("feeder_bought", FeederIndex);
        }
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }

    public void BuyDiamondFeederBtn()
    {
        if (PlayerPrefs.GetInt("feeder" + FeederIndex) == 0)
        {


            if (DiamondCoins >= _FeederData.Feeder_stats[FeederIndex].Diamondprice)
            {

                if (FeederIndex == 4 || FeederIndex == 5 || FeederIndex == 6)
                {

                    PlayerPrefs.SetInt("diamonds", DiamondCoins - (_FeederData.Feeder_stats[FeederIndex].Diamondprice));
                    DiamondCoins = PlayerPrefs.GetInt("diamonds");
                    DiamondCoinsText.text = PlayerPrefs.GetInt("diamonds").ToString() + " D";

                    FeederLockImage.gameObject.SetActive(false);
                    BuyFeederToffeeBtn.SetActive(false);
                    BuyFeederDiamondBtn.SetActive(false);
                    CongratsFeeder();
                    //WatchVideoBtn.SetActive(false);
                    SelectFeederBtn.SetActive(true);
                    PlayerPrefs.SetInt("feeder" + FeederIndex, 1);
                    PlayerPrefs.SetInt("feeder_bought", FeederIndex);
                }
            }



            else
            {
                ShopPanels[ShopButtonsIndex].SetActive(false);
                NotEnoughCashPanel.SetActive(true);
            }
        }

        else if (PlayerPrefs.GetInt("feeder" + FeederIndex) == 1)
        {


            PlayerPrefs.SetInt("feeder_bought", FeederIndex);
        }
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }
    void CongratsFeeder()
    {
        CongratsFeederPanel.SetActive(true);
        CongratsFedderItemImage.sprite = _FeederData.Feeder_stats[FeederIndex].Icon;
        CongratsFeederItemName.text = _FeederData.Feeder_stats[FeederIndex].Name;
        MenuSceneManager.Instance.ShopCamera.SetActive(false);
        MenuSceneManager.Instance.TopDownCamera.SetActive(true);
        for (int i = 0; i < Feeders.Length; i++)
        {
            Feeders[i].SetActive(false);
        }
        
        AudioManager.instance.PlaySound("congrats");
    }


    public void SelectFeeder()
    {


        PlayerPrefs.SetInt("feeder" + FeederIndex, 0);

        CongratsFeederPanel.SetActive(false);
        FeederPanel.SetActive(false);
        ShopMainPanel.SetActive(false);
        ShopButton.SetActive(true);
        for (int i = 0; i < Feeders.Length; i++)
        {
            Feeders[i].SetActive(true);
        }
        ShopButtonsIndex = 0;

        MenuSceneManager.Instance.ShopCamera.SetActive(false);
        MenuSceneManager.Instance.TopDownCamera.SetActive(true);

        //Instantiate(_PlayerData.stats[PlayerIndex].HamsterPrefab, MenuSceneManager.Instance.PlayersSpwanPoint[PlayerIndex].transform.position, MenuSceneManager.Instance.PlayersSpwanPoint[PlayerIndex].transform.rotation);
        //PlayerPrefs.SetInt("hamster" + PlayerIndex, HamsterCount[PlayerIndex]++);
        //Debug.Log(PlayerPrefs.GetInt("hamster" + PlayerIndex));

        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");
    }

    #endregion

    #region ToysData
    public void NextToybutton_F()
    {
        ToyIndex++;
        ToynameText.text = _WheelData.Wheel_stats[ToyIndex].Name;

        ToyDiscription.text = _WheelData.Wheel_stats[ToyIndex].Discription;



        ToyImage.sprite = _WheelData.Wheel_stats[ToyIndex].Icon;


        //DiamondPriceText.text = _PlayerData.stats[PlayerIndex].Diamonds.ToString() + " D";
        ToyPriceText.text = _WheelData.Wheel_stats[ToyIndex].price.ToString() + " T";

        for (int i = 0; i <= Toys.Length - 1; i++)
        {
            Toys[i].SetActive(false);
        }
        Toys[ToyIndex].SetActive(true);

        if (ToyIndex >= 0)
        {
            ToyPreviousBtn.SetActive(true);
        }
        if (ToyIndex == Toys.Length - 1)
        {
            ToyNextBtn.SetActive(false);
        }
        if (PlayerPrefs.GetInt("toy" + ToyIndex) == 1)
        {
            ToyPriceText.text = "Owned";
            BuyToyToffeeBtn.SetActive(false);
            BuyToyDiamondBtn.SetActive(false); 
            ToyLockImage.gameObject.SetActive(false);
            SelectToyBtn.SetActive(true);

        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (ToyIndex == 1 || ToyIndex == 2 || ToyIndex == 3)
            {
                BuyToyToffeeBtn.SetActive(true);
                BuyToyDiamondBtn.SetActive(false);
                ToyPriceText.text = _WheelData.Wheel_stats[ToyIndex].price.ToString() + " T";
            }
            else if (ToyIndex == 4 || ToyIndex == 5 || ToyIndex==6)
            {
                BuyToyDiamondBtn.SetActive(true);
                BuyToyToffeeBtn.SetActive(false);
                ToyPriceText.text = _WheelData.Wheel_stats[ToyIndex].price.ToString() + " D";
            }

            SelectToyBtn.SetActive(false);
            ToyLockImage.gameObject.SetActive(true);
        }

        FindObjectOfType<AudioManager>().PlaySound("next");

        Toys[ToyIndex].GetComponent<DOTweenAnimation>().DORestartById("toy");

    }


    public void PreviousToy_F()
    {
        ToyIndex--;
        ToynameText.text = _WheelData.Wheel_stats[ToyIndex].Name;

        ToyDiscription.text = _WheelData.Wheel_stats[ToyIndex].Discription;



        ToyImage.sprite = _WheelData.Wheel_stats[ToyIndex].Icon;



        ToyPriceText.text = _WheelData.Wheel_stats[ToyIndex].price.ToString() + " T";
        for (int i = 0; i <= Toys.Length - 1; i++)
        {
            Toys[i].SetActive(false);
        }
        Toys[ToyIndex].SetActive(true);

        if (ToyIndex <= Toys.Length)
        {
            ToyNextBtn.SetActive(true);
        }
        if (ToyIndex == 0)
        {
            ToyPreviousBtn.SetActive(false);
            BuyToyToffeeBtn.SetActive(false);
            BuyToyDiamondBtn.SetActive(false);
            ToyLockImage.gameObject.SetActive(false);
            SelectToyBtn.SetActive(true);
            ToyPriceText.text = "Owned";
        }
        if (PlayerPrefs.GetInt("toy" + ToyIndex) == 1)
        {
            ToyPriceText.text = "Owned";
            BuyToyToffeeBtn.SetActive(false);
            BuyToyDiamondBtn.SetActive(false);
            ToyLockImage.gameObject.SetActive(false);
            SelectToyBtn.SetActive(true);

        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (ToyIndex == 1 || ToyIndex == 2 || ToyIndex == 3)
            {
                BuyToyToffeeBtn.SetActive(true);
                BuyToyDiamondBtn.SetActive(false);
                ToyPriceText.text = _WheelData.Wheel_stats[ToyIndex].price.ToString() + " T";
            }
            else if (ToyIndex == 4 || ToyIndex == 5 || ToyIndex == 6)
            {
                BuyToyDiamondBtn.SetActive(true);
                BuyToyToffeeBtn.SetActive(false);
                ToyPriceText.text = _WheelData.Wheel_stats[ToyIndex].price.ToString() + " D";
            }

            SelectToyBtn.SetActive(false);
            ToyLockImage.gameObject.SetActive(true);
        }
        FindObjectOfType<AudioManager>().PlaySound("next");
        Toys[ToyIndex].GetComponent<DOTweenAnimation>().DORestartById("toy");

    }

    public void BuyToyBtn()
    {
        if (PlayerPrefs.GetInt("toy" + ToyIndex) == 0)
        {

            if (ToffeeCoins >= _WheelData.Wheel_stats[ToyIndex].price)
            {
                if (ToyIndex == 1 || ToyIndex == 2 || ToyIndex == 3)
                {
                    PlayerPrefs.SetInt("coins", ToffeeCoins - (_WheelData.Wheel_stats[ToyIndex].price));
                    ToffeeCoins = PlayerPrefs.GetInt("coins");
                    ToffeeCoinsText.text = PlayerPrefs.GetInt("coins").ToString() + " T";

                    ToyLockImage.gameObject.SetActive(false);
                    BuyToyToffeeBtn.SetActive(false);
                    BuyToyDiamondBtn.SetActive(false);
                    CongratsToy();
                    //WatchVideoBtn.SetActive(false);
                    SelectToyBtn.SetActive(true);
                    PlayerPrefs.SetInt("toy" + ToyIndex, 1);
                    PlayerPrefs.SetInt("toy_bought", ToyIndex);
                }

            }
                

            else
            {
                ShopPanels[ShopButtonsIndex].SetActive(false);
                NotEnoughCashPanel.SetActive(true);
            }
        }

        else if (PlayerPrefs.GetInt("toy" + ToyIndex) == 1)
        {


            PlayerPrefs.SetInt("toy_bought", ToyIndex);
        }
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }

    public void BuyDiamondToyBtn()
    {
        if (PlayerPrefs.GetInt("toy" + ToyIndex) == 0)
        {


            if (DiamondCoins >= _WheelData.Wheel_stats[ToyIndex].Diamondprice)
            {
                if (ToyIndex == 4 || ToyIndex == 5 || ToyIndex == 6)
                {

                    PlayerPrefs.SetInt("diamonds", DiamondCoins - (_WheelData.Wheel_stats[ToyIndex].Diamondprice));
                    DiamondCoins = PlayerPrefs.GetInt("diamonds");
                    DiamondCoinsText.text = PlayerPrefs.GetInt("diamonds").ToString() + " D";

                    ToyLockImage.gameObject.SetActive(false);
                    BuyToyToffeeBtn.SetActive(false);
                    BuyToyDiamondBtn.SetActive(false);
                    CongratsToy();
                    //WatchVideoBtn.SetActive(false);
                    SelectToyBtn.SetActive(true);
                    PlayerPrefs.SetInt("toy" + ToyIndex, 1);
                    PlayerPrefs.SetInt("toy_bought", ToyIndex);
                }
            }



            else
            {
                ShopPanels[ShopButtonsIndex].SetActive(false);
                NotEnoughCashPanel.SetActive(true);
            }
        }

        else if (PlayerPrefs.GetInt("toy" + ToyIndex) == 1)
        {


            PlayerPrefs.SetInt("toy_bought", ToyIndex);
        }
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }

    void CongratsToy()
    {
        CongratsToyPanel.SetActive(true);
        CongratsToyItemImage.sprite = _WheelData.Wheel_stats[ToyIndex].Icon;
        CongratsToyItemName.text = _WheelData.Wheel_stats[ToyIndex].Name;
        MenuSceneManager.Instance.ShopCamera.SetActive(false);
        MenuSceneManager.Instance.TopDownCamera.SetActive(true);
        for (int i = 0; i < Toys.Length; i++)
        {
            Toys[i].SetActive(false);
        }
        
        AudioManager.instance.PlaySound("congrats");
    }


    public void SelectToy()
    {


        PlayerPrefs.SetInt("toy" + ToyIndex, 0);

        CongratsToyPanel.SetActive(false);
        WheelPanel.SetActive(false);
        ShopMainPanel.SetActive(false);
        ShopButton.SetActive(true);
        for (int i = 0; i < Toys.Length; i++)
        {
            Toys[i].SetActive(true);
        }
        ShopButtonsIndex = 0;

        MenuSceneManager.Instance.ShopCamera.SetActive(false);
        MenuSceneManager.Instance.TopDownCamera.SetActive(true);

        //Instantiate(_PlayerData.stats[PlayerIndex].HamsterPrefab, MenuSceneManager.Instance.PlayersSpwanPoint[PlayerIndex].transform.position, MenuSceneManager.Instance.PlayersSpwanPoint[PlayerIndex].transform.rotation);
        //PlayerPrefs.SetInt("hamster" + PlayerIndex, HamsterCount[PlayerIndex]++);
        //Debug.Log(PlayerPrefs.GetInt("hamster" + PlayerIndex));
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }

    #endregion

    #region CageData
    public void NextCagebutton_F()
    {
        CageIndex++;
        CagenameText.text = _CageData.Cage_Data[CageIndex].Name;

        CageDiscription.text = _CageData.Cage_Data[CageIndex].Discription;



        CageImage.sprite = _CageData.Cage_Data[CageIndex].Icon;


        //DiamondPriceText.text = _PlayerData.stats[PlayerIndex].Diamonds.ToString() + " D";
        CagePriceText.text = _CageData.Cage_Data[CageIndex].price.ToString() + " T";

        for (int i = 0; i <= Cages.Length - 1; i++)
        {
            Cages[i].SetActive(false);
        }
        Cages[CageIndex].SetActive(true);

        if (CageIndex >= 0)
        {
            CagePreviousBtn.SetActive(true);
        }
        if (CageIndex == Cages.Length - 1)
        {
            CageNextBtn.SetActive(false);
        }
        if (PlayerPrefs.GetInt("cage" + CageIndex) == 1)
        {
            CagePriceText.text = "Owned";
            BuyCageToffeeBtn.SetActive(false);
            BuyCageDiamondBtn.SetActive(false);
            CageLockImage.gameObject.SetActive(false);
            SelectCageBtn.SetActive(true);

        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (CageIndex == 1 || CageIndex == 2 )
            {
                BuyCageToffeeBtn.SetActive(true);
                BuyCageDiamondBtn.SetActive(false);
                CagePriceText.text = _CageData.Cage_Data[CageIndex].price.ToString() + " T";
            }
            else if (CageIndex == 3 || CageIndex == 4)
            {
                BuyCageDiamondBtn.SetActive(true);
                BuyCageToffeeBtn.SetActive(false);
                CagePriceText.text = _CageData.Cage_Data[CageIndex].price.ToString() + " D";
            }

            SelectCageBtn.SetActive(false);
            CageLockImage.gameObject.SetActive(true);
        }

        FindObjectOfType<AudioManager>().PlaySound("next");

        Cages[CageIndex].GetComponent<DOTweenAnimation>().DORestartById("cage");

    }


    public void PreviousCage_F()
    {
        CageIndex--;
        CagenameText.text = _CageData.Cage_Data[CageIndex].Name;

        CageDiscription.text = _CageData.Cage_Data[CageIndex].Discription;



        CageImage.sprite = _CageData.Cage_Data[CageIndex].Icon;



        CagePriceText.text = _CageData.Cage_Data[CageIndex].price.ToString() + " T";
        for (int i = 0; i <= Cages.Length - 1; i++)
        {
            Cages[i].SetActive(false);
        }
        Cages[CageIndex].SetActive(true);

        if (CageIndex <= Cages.Length)
        {
            CageNextBtn.SetActive(true);
        }
        if (CageIndex == 0)
        {
            CagePreviousBtn.SetActive(false);
            BuyCageToffeeBtn.SetActive(false);
            BuyCageDiamondBtn.SetActive(false);
            CageLockImage.gameObject.SetActive(false);
            SelectCageBtn.SetActive(true);
            CagePriceText.text = "Owned";
        }
        if (PlayerPrefs.GetInt("cage" + CageIndex) == 1)
        {
            CagePriceText.text = "Owned";
            BuyCageToffeeBtn.SetActive(false);
            BuyCageDiamondBtn.SetActive(false);
            CageLockImage.gameObject.SetActive(false);
            SelectCageBtn.SetActive(true);

        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (CageIndex == 1 || CageIndex == 2 )
            {
                BuyCageToffeeBtn.SetActive(true);
                BuyCageDiamondBtn.SetActive(false);
                CagePriceText.text = _CageData.Cage_Data[CageIndex].price.ToString() + " T";
            }
            else if (CageIndex == 3 || CageIndex == 4)
            {
                BuyCageDiamondBtn.SetActive(true);
                BuyCageToffeeBtn.SetActive(false);
                CagePriceText.text = _CageData.Cage_Data[CageIndex].price.ToString() + " D";
            }

            SelectCageBtn.SetActive(false);
            CageLockImage.gameObject.SetActive(true);
        }
        FindObjectOfType<AudioManager>().PlaySound("next");
        Cages[CageIndex].GetComponent<DOTweenAnimation>().DORestartById("cage");
    }


    public void BuyCageBtn()
    {
        if (PlayerPrefs.GetInt("cage" + CageIndex) == 0)
        {

            if (ToffeeCoins >= _CageData.Cage_Data[CageIndex].price)
            {
                if (CageIndex == 1 || CageIndex == 2 || CageIndex == 3)
                {
                    PlayerPrefs.SetInt("coins", ToffeeCoins - (_CageData.Cage_Data[CageIndex].price));
                    ToffeeCoins = PlayerPrefs.GetInt("coins");
                    ToffeeCoinsText.text = PlayerPrefs.GetInt("coins").ToString() + " T";

                    CageLockImage.gameObject.SetActive(false);
                    BuyCageToffeeBtn.SetActive(false);
                    BuyCageDiamondBtn.SetActive(false);
                    CongratsCage();
                    //WatchVideoBtn.SetActive(false);
                    SelectCageBtn.SetActive(true);
                    PlayerPrefs.SetInt("cage" + CageIndex, 1);
                    PlayerPrefs.SetInt("cage_bought", CageIndex);
                }

            }
                

            else
            {
                ShopPanels[ShopButtonsIndex].SetActive(false);
                NotEnoughCashPanel.SetActive(true);
            }
        }

        else if (PlayerPrefs.GetInt("cage" + CageIndex) == 1)
        {


            PlayerPrefs.SetInt("cage_bought", CageIndex);
        }
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }


    public void BuyDiamondCageBtn()
    {
        if (PlayerPrefs.GetInt("cage" + CageIndex) == 0)
        {


            if (DiamondCoins >= _CageData.Cage_Data[CageIndex].Diamondprice)
            {
                if (CageIndex == 4 || CageIndex == 5 || CageIndex == 6)
                {

                    PlayerPrefs.SetInt("diamonds", DiamondCoins - (_CageData.Cage_Data[CageIndex].Diamondprice));
                    DiamondCoins = PlayerPrefs.GetInt("diamonds");
                    DiamondCoinsText.text = PlayerPrefs.GetInt("diamonds").ToString() + " D";

                    CageLockImage.gameObject.SetActive(false);
                    BuyCageToffeeBtn.SetActive(false);
                    BuyCageDiamondBtn.SetActive(false);
                    CongratsCage();
                    //WatchVideoBtn.SetActive(false);
                    SelectCageBtn.SetActive(true);
                    PlayerPrefs.SetInt("cage" + CageIndex, 1);
                    PlayerPrefs.SetInt("cage_bought", CageIndex);
                }
            }



            else
            {
                ShopPanels[ShopButtonsIndex].SetActive(false);
                NotEnoughCashPanel.SetActive(true);
            }
        }

        else if (PlayerPrefs.GetInt("cage" + CageIndex) == 1)
        {


            PlayerPrefs.SetInt("cage_bought", CageIndex);
        }
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }



    void CongratsCage()
    {
        CongratsCagePanel.SetActive(true);
        CongratsCageItemImage.sprite = _CageData.Cage_Data[CageIndex].Icon;
        CongratsCageItemName.text = _CageData.Cage_Data[CageIndex].Name;
        MenuSceneManager.Instance.ShopCamera.SetActive(false);
        MenuSceneManager.Instance.TopDownCamera.SetActive(true);
        for (int i = 0; i < Cages.Length; i++)
        {
            Cages[i].SetActive(false);
        }
        
        AudioManager.instance.PlaySound("congrats");
    }


    public void SelectCage()
    {


        PlayerPrefs.SetInt("cage" + CageIndex, 0);

        CongratsCagePanel.SetActive(false);
        CagePanel.SetActive(false);
        ShopMainPanel.SetActive(false);
        ShopButton.SetActive(true);
        for (int i = 0; i < Cages.Length; i++)
        {
            Cages[i].SetActive(true);
        }
        ShopButtonsIndex = 0;

        MenuSceneManager.Instance.ShopCamera.SetActive(false);
        MenuSceneManager.Instance.TopDownCamera.SetActive(true);

        //Instantiate(_PlayerData.stats[PlayerIndex].HamsterPrefab, MenuSceneManager.Instance.PlayersSpwanPoint[PlayerIndex].transform.position, MenuSceneManager.Instance.PlayersSpwanPoint[PlayerIndex].transform.rotation);
        //PlayerPrefs.SetInt("hamster" + PlayerIndex, HamsterCount[PlayerIndex]++);
        //Debug.Log(PlayerPrefs.GetInt("hamster" + PlayerIndex));

        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");
    }

    #endregion


    #region BGData
    public void NextBGbutton_F()
    {
        BGIndex++;
        BGnameText.text = _BGData.BG[BGIndex].Name;

        BGDiscription.text = _BGData.BG[BGIndex].Discription;



        BGImage.sprite = _BGData.BG[BGIndex].Icon;


        //DiamondPriceText.text = _PlayerData.stats[PlayerIndex].Diamonds.ToString() + " D";
        BGPriceText.text = _BGData.BG[BGIndex].price.ToString() + " T";

        for (int i = 0; i <= BGs.Length - 1; i++)
        {
            BGs[i].SetActive(false);
        }
        BGs[BGIndex].SetActive(true);

        if (BGIndex >= 0)
        {
            BGPreviousBtn.SetActive(true);
        }
        if (BGIndex == BGs.Length - 1)
        {
            BGNextBtn.SetActive(false);
        }
        if (PlayerPrefs.GetInt("bg" + BGIndex) == 1)
        {
            BGPriceText.text = "Owned";
            BuyBGToffeeBtn.SetActive(false);
            BuyBGDiamondBtn.SetActive(false);
            BGLockImage.gameObject.SetActive(false);
            SelectBGBtn.SetActive(true);

        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (BGIndex == 1 || BGIndex == 2 || BGIndex == 3)
            {
                BuyBGToffeeBtn.SetActive(true);
                BuyBGDiamondBtn.SetActive(false);
                BGPriceText.text = _BGData.BG[BGIndex].price.ToString() + " T";
            }
            else if (BGIndex == 4 || BGIndex == 5 || BGIndex == 6)
            {
                BuyBGDiamondBtn.SetActive(true);
                BuyBGToffeeBtn.SetActive(false);
                BGPriceText.text = _BGData.BG[BGIndex].price.ToString() + " D";
            }

            SelectBGBtn.SetActive(false);
            BGLockImage.gameObject.SetActive(true);
        }

        FindObjectOfType<AudioManager>().PlaySound("next");

        BGs[BGIndex].GetComponent<DOTweenAnimation>().DORestartById("bg");

    }


    public void PreviousBG_F()
    {
        BGIndex--;
        BGnameText.text = _BGData.BG[BGIndex].Name;

        BGDiscription.text = _BGData.BG[BGIndex].Discription;



        BGImage.sprite = _BGData.BG[BGIndex].Icon;



        BGPriceText.text = _BGData.BG[BGIndex].price.ToString() + " T";
        for (int i = 0; i <= BGs.Length - 1; i++)
        {
            BGs[i].SetActive(false);
        }
        BGs[BGIndex].SetActive(true);

        if (BGIndex <= BGs.Length)
        {
            BGNextBtn.SetActive(true);
        }
        if (BGIndex == 0)
        {
            BGPreviousBtn.SetActive(false);
            BuyBGToffeeBtn.SetActive(false);
            BuyBGDiamondBtn.SetActive(false);
            BGLockImage.gameObject.SetActive(false);
            SelectBGBtn.SetActive(true);
            BGPriceText.text = "Owned";
        }
        if (PlayerPrefs.GetInt("bg" + BGIndex) == 1)
        {
            BGPriceText.text = "Owned";
            BuyBGToffeeBtn.SetActive(false);
            BuyBGDiamondBtn.SetActive(false);
            BGLockImage.gameObject.SetActive(false);
            SelectBGBtn.SetActive(true);

        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (BGIndex == 1 || BGIndex == 2 || BGIndex == 3)
            {
                BuyBGToffeeBtn.SetActive(true);
                BuyBGDiamondBtn.SetActive(false);
                BGPriceText.text = _BGData.BG[BGIndex].price.ToString() + " T";
            }
            else if (BGIndex == 4 || BGIndex == 5 || BGIndex == 6)
            {
                BuyBGDiamondBtn.SetActive(true);
                BuyBGToffeeBtn.SetActive(false);
                BGPriceText.text = _BGData.BG[BGIndex].price.ToString() + " D";
            }

            SelectBGBtn.SetActive(false);
            BGLockImage.gameObject.SetActive(true);
        }
        FindObjectOfType<AudioManager>().PlaySound("next");
        BGs[BGIndex].GetComponent<DOTweenAnimation>().DORestartById("bg");
    }


    public void BuyBGBtn()
    {
        if (PlayerPrefs.GetInt("bg" + BGIndex) == 0)
        {

            if (ToffeeCoins >= _BGData.BG[BGIndex].price)
            {
                if (BGIndex == 1 || BGIndex == 2 || BGIndex == 3)
                {
                    PlayerPrefs.SetInt("coins", ToffeeCoins - (_BGData.BG[BGIndex].Diamondprice));
                    ToffeeCoins = PlayerPrefs.GetInt("coins");
                    ToffeeCoinsText.text = PlayerPrefs.GetInt("coins").ToString() + " T";

                    BGLockImage.gameObject.SetActive(false);
                    BuyBGToffeeBtn.SetActive(false);
                    BuyBGDiamondBtn.SetActive(false);
                    CongratsBg();
                    //WatchVideoBtn.SetActive(false);
                    SelectBGBtn.SetActive(true);
                    PlayerPrefs.SetInt("bg" + BGIndex, 1);
                    PlayerPrefs.SetInt("bg_bought", BGIndex);
                }

            }
               
            else
            {
                ShopPanels[ShopButtonsIndex].SetActive(false);
                NotEnoughCashPanel.SetActive(true);
            }
        }

        else if (PlayerPrefs.GetInt("bg" + BGIndex) == 1)
        {


            PlayerPrefs.SetInt("bg_bought", BGIndex);
        }
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }


    public void BuyDiamondBGBtn()
    {
        if (PlayerPrefs.GetInt("bg" + BGIndex) == 0)
        {


            if (DiamondCoins >= _BGData.BG[BGIndex].Diamondprice)
            {

                if (BGIndex == 4 || BGIndex == 5 || BGIndex == 6)
                {

                    PlayerPrefs.SetInt("diamonds", DiamondCoins - (_BGData.BG[BGIndex].Diamondprice));
                    DiamondCoins = PlayerPrefs.GetInt("diamonds");
                    DiamondCoinsText.text = PlayerPrefs.GetInt("diamonds").ToString() + " D";

                    BGLockImage.gameObject.SetActive(false);
                    BuyBGToffeeBtn.SetActive(false);
                    BuyBGDiamondBtn.SetActive(false);
                    CongratsBg();
                    //WatchVideoBtn.SetActive(false);
                    SelectBGBtn.SetActive(true);
                    PlayerPrefs.SetInt("bg" + BGIndex, 1);
                    PlayerPrefs.SetInt("bg_bought", BGIndex);
                }
            }



            else
            {
                ShopPanels[ShopButtonsIndex].SetActive(false);
                NotEnoughCashPanel.SetActive(true);
            }
        }

        else if (PlayerPrefs.GetInt("bg" + BGIndex) == 1)
        {


            PlayerPrefs.SetInt("bg_bought", BGIndex);
        }
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");

    }



    void CongratsBg()
    {
        CongratsBgPanel.SetActive(true);
        CongratsBgItemImage.sprite = _BGData.BG[BGIndex].Icon;
        CongratsBgItemName.text = _BGData.BG[BGIndex].Name;
        MenuSceneManager.Instance.ShopCamera.SetActive(false);
        MenuSceneManager.Instance.TopDownCamera.SetActive(true);
        for (int i = 0; i < BGs.Length; i++)
        {
            BGs[i].SetActive(false);
        }
       
        AudioManager.instance.PlaySound("congrats");
    }


    public void SelectBG()
    {


        

        CongratsBgPanel.SetActive(false);
        BGPanel.SetActive(false);
        ShopMainPanel.SetActive(false);
        ShopButton.SetActive(true);
        for (int i = 0; i < BGs.Length; i++)
        {
            BGs[i].SetActive(true);
        }
        ShopButtonsIndex = 0;
        MenuSceneManager.Instance.ShopCamera.SetActive(false);
        MenuSceneManager.Instance.TopDownCamera.SetActive(true);
        PlayerPrefs.SetInt("bg_bought", BGIndex);
        RenderSettings.skybox = _BGData.BG[BGIndex].Mat;
        MenuSceneManager.Instance.DirectionalLight.GetComponent<Light>().color = _BGData.BG[BGIndex].LightColor;
        FindObjectOfType<AudioManager>().PlaySound("shopbuttons");
    }

    #endregion
}
