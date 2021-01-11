using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiMangerMenu : MonoBehaviour
{
    #region Singleton
    private static UiMangerMenu _Instance;
    public static UiMangerMenu Instance
    {
        get
        {

            if (!_Instance) _Instance = FindObjectOfType<UiMangerMenu>();

            return _Instance;
        }
    }

    private void Awake()
    {
        if (!_Instance) _Instance = this;

      
    }
    #endregion
    #region Variables
    [Header("<--- Player Stats --->")]
    public PlayerData _PlayerData;
    public BowlData _BowlData;
    public HouseData _HouseData;
    public FoodData _FoodData;
    public WheelData _WheelData;
    [Header("<--- Panels --->")]

    public GameObject PlayerPanel;
    public GameObject BowlPanel;
    public GameObject FoodPanel;
    public GameObject WheelPanel;
    public GameObject HosuePanel;
    public GameObject NotEnoughCashPanel;

    [Header("<--- Player Stats --->")]
    public Image PlayerImage;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI Health;
    public TextMeshProUGUI Damage;
    public TextMeshProUGUI Defence;
    public TextMeshProUGUI Speed;
    public TextMeshProUGUI Discription;
    public TextMeshProUGUI ToffeeCoinsText;
    public TextMeshProUGUI DiamondCoinsText;
    public TextMeshProUGUI PriceText;
    public TextMeshProUGUI DiamondPriceText;
    public Image PlayerLock;
    public int ToffeeCoins;
    public int DiamondCoins;
    public int PlayerIndex;
    public GameObject BuyToffeeBtn;
    public GameObject BuyDiamondBtn;
    public GameObject SelectBtn;


    public Image HealthSlider;
    public Image DamageSlider;
    public Image DefenceSlider;
    public Image SpeedSlider;

    public int[] HamsterCount;

    [Header("<--- Bowl Stats --->")]
    public Image BowlImage;
    public Image BowlLockImage;
    public TextMeshProUGUI BowlnameText;
    public TextMeshProUGUI BowlPriceText;
    public TextMeshProUGUI BowlDiscription;

    public int BowlIndex;
    public GameObject BowlBuyBtn;
    public GameObject BowlSelectBtn;

    [Header("<--- House Stats --->")]
    public Image HouseImage;
    public Image HouseLockImage;
    public TextMeshProUGUI HousenameText;
    public TextMeshProUGUI HousePriceText;
    public TextMeshProUGUI HouseDiscription;

    public int HouseIndex;
    public GameObject HouseBuyBtn;
    public GameObject HouseSelectBtn;

    [Header("<--- Food Stats --->")]
    public Image FoodImage;
    public Image FoodLockImage;
    public TextMeshProUGUI FoodnameText;
    public TextMeshProUGUI FoodDiscription;
    public TextMeshProUGUI FoodPriceText;

    public int FoodIndex;
    public GameObject FoodBuyBtn;
    public GameObject FoodSelectBtn;

    [Header("<--- Wheel Stats --->")]
    public Image WheelImage;
    public Image WheelLockImage;
    public TextMeshProUGUI WheelnameText;
    public TextMeshProUGUI WheelDiscription;
    public TextMeshProUGUI WheelPriceText;

    public int WheelIndex;
    public GameObject WheelBuyBtn;
    public GameObject WheelSelectBtn;

    #endregion
    // Start is called before the first frame update
    void Start()
    {
         PlayerPrefs.SetInt("coins", 300);
         PlayerPrefs.SetInt("diamonds", 100);
         //PlayerPrefs.DeleteAll();

        if (!PlayerPrefs.HasKey("coins"))
        {
            PlayerPrefs.SetInt("players" + 0, 1);
            PlayerPrefs.SetInt("bowl" + 0, 1);
            PlayerPrefs.SetInt("house" + 0, 1);
            PlayerPrefs.SetInt("food" + 0, 1);
            PlayerPrefs.SetInt("wheel" + 0, 1);
            PlayerPrefs.SetInt("coins", 5);
            PlayerPrefs.SetInt("diamonds", 1);
            ToffeeCoins = PlayerPrefs.GetInt("coins");
            DiamondCoins = PlayerPrefs.GetInt("diamonds");
            ToffeeCoinsText.text = ToffeeCoins.ToString() + " T";
            DiamondCoins = PlayerPrefs.GetInt("diamonds");
            DiamondCoinsText.text = DiamondCoins.ToString() + " D";
            PlayerLock.gameObject.SetActive(false);
        }
        else
        {

            ToffeeCoins = PlayerPrefs.GetInt("coins");
            ToffeeCoinsText.text = ToffeeCoins.ToString() + " T";

            DiamondCoins = PlayerPrefs.GetInt("diamonds");
            DiamondCoinsText.text = DiamondCoins.ToString() + " D";
        }


      
        


        if (PlayerPrefs.HasKey("hamster0"))
        {
            HamsterCount[0] = PlayerPrefs.GetInt("hamster0")+1;
            Debug.Log("hamster0" + PlayerPrefs.GetInt("hamster0"));

            for (int i = 0; i <= PlayerPrefs.GetInt("hamster0"); i++)
            {

                Instantiate(_PlayerData.stats[0].HamsterPrefab);
            }
        }
        if (PlayerPrefs.HasKey("hamster1"))
        {
            HamsterCount[1] = PlayerPrefs.GetInt("hamster1")+1;
            Debug.Log("hamster1" + PlayerPrefs.GetInt("hamster1"));

            for (int i = 0; i <= PlayerPrefs.GetInt("hamster1"); i++)
            {

                Instantiate(_PlayerData.stats[1].HamsterPrefab, MenuSceneManager.Instance.PlayersSpwanPoint[1].transform.position, MenuSceneManager.Instance.PlayersSpwanPoint[1].transform.rotation);
            }
        }
        if (PlayerPrefs.HasKey("hamster2"))
        {
            HamsterCount[2] = PlayerPrefs.GetInt("hamster2")+1;
            Debug.Log("hamster2" + PlayerPrefs.GetInt("hamster2"));

            for (int i = 0; i <= PlayerPrefs.GetInt("hamster2"); i++)
            {

                Instantiate(_PlayerData.stats[2].HamsterPrefab, MenuSceneManager.Instance.PlayersSpwanPoint[2].transform.position, MenuSceneManager.Instance.PlayersSpwanPoint[2].transform.rotation);
            }
        }
        if (PlayerPrefs.HasKey("hamster3"))
        {
            HamsterCount[3] = PlayerPrefs.GetInt("hamster3")+1;
            Debug.Log("hamster3" + PlayerPrefs.GetInt("hamster3"));

            for (int i = 0; i <= PlayerPrefs.GetInt("hamster3"); i++)
            {

                Instantiate(_PlayerData.stats[3].HamsterPrefab, MenuSceneManager.Instance.PlayersSpwanPoint[3].transform.position, MenuSceneManager.Instance.PlayersSpwanPoint[3].transform.rotation);
            }
        }
        if (PlayerPrefs.HasKey("hamster4"))
        {
            HamsterCount[4] = PlayerPrefs.GetInt("hamster4")+1;
            Debug.Log("hamster4" + PlayerPrefs.GetInt("hamster4"));

            for (int i = 0; i <= PlayerPrefs.GetInt("hamster4"); i++)
            {

                Instantiate(_PlayerData.stats[4].HamsterPrefab, MenuSceneManager.Instance.PlayersSpwanPoint[4].transform.position, MenuSceneManager.Instance.PlayersSpwanPoint[4].transform.rotation);
            }
        }
        if (PlayerPrefs.HasKey("hamster5"))
        {
            HamsterCount[5] = PlayerPrefs.GetInt("hamster5")+1;
            Debug.Log("hamster5" + PlayerPrefs.GetInt("hamster5"));

            for (int i = 0; i <= PlayerPrefs.GetInt("hamster5"); i++)
            {

                Instantiate(_PlayerData.stats[5].HamsterPrefab, MenuSceneManager.Instance.PlayersSpwanPoint[5].transform.position, MenuSceneManager.Instance.PlayersSpwanPoint[5].transform.rotation);
            }
        }
        if (PlayerPrefs.HasKey("hamster6"))
        {
            HamsterCount[6] = PlayerPrefs.GetInt("hamster6")+1;
            Debug.Log("hamster6" + PlayerPrefs.GetInt("hamster6"));

            for (int i = 0; i <= PlayerPrefs.GetInt("hamster6"); i++)
            {

                Instantiate(_PlayerData.stats[6].HamsterPrefab, MenuSceneManager.Instance.PlayersSpwanPoint[6].transform.position, MenuSceneManager.Instance.PlayersSpwanPoint[6].transform.rotation);
            }
        }

    }

    public void PlayerBtn()
    {
        PlayerPanel.SetActive(true);
        
        BowlPanel.SetActive(false);
        FoodPanel.SetActive(false);
        WheelPanel.SetActive(false);
        HosuePanel.SetActive(false);

    }

    public void BowlBtn()
    {
        PlayerPanel.SetActive(false);

        BowlPanel.SetActive(true);
        FoodPanel.SetActive(false);
        WheelPanel.SetActive(false);
        HosuePanel.SetActive(false);

    }


    public void WheelBtn()
    {
        PlayerPanel.SetActive(false);

        BowlPanel.SetActive(false);
        FoodPanel.SetActive(false);
        WheelPanel.SetActive(true);
        HosuePanel.SetActive(false);

    }

    public void HouseBtn()
    {
        PlayerPanel.SetActive(false);

        BowlPanel.SetActive(false);
        FoodPanel.SetActive(false);
        WheelPanel.SetActive(false);
        HosuePanel.SetActive(true);



    }

    public void FoodBtn()
    {
        PlayerPanel.SetActive(false);

        BowlPanel.SetActive(false);
        FoodPanel.SetActive(true);
        WheelPanel.SetActive(false);
        HosuePanel.SetActive(false);

    }


    public void SelectBowl(int i)
    {
        BowlImage.sprite = _BowlData.Bowl_stats[i].Icon;

        BowlnameText.text = _BowlData.Bowl_stats[i].Name;
        BowlDiscription.text = _BowlData.Bowl_stats[i].Discription;

        BowlPriceText.text = _BowlData.Bowl_stats[i].price.ToString() + " $";

        if (i == 0)
        {

            BowlBuyBtn.SetActive(false);
            // WatchVideoBtn.SetActive(false);
            BowlSelectBtn.SetActive(true);
            BowlLockImage.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("bowl" + i) == 1)
        {
            // PriceText.text = "Owned";
            BowlBuyBtn.SetActive(false);
            // WatchVideoBtn.SetActive(false);
           
            BowlSelectBtn.SetActive(true);
            BowlLockImage.gameObject.SetActive(false);
        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            BowlBuyBtn.SetActive(true);
            BowlSelectBtn.SetActive(false);
            BowlLockImage.gameObject.SetActive(true);
        }
        BowlIndex = i;

    }


    public void SelectHouse(int i)
    {
        HouseImage.sprite = _HouseData.House_stats[i].Icon;

        HousenameText.text = _HouseData.House_stats[i].Name;
        HouseDiscription.text = _HouseData.House_stats[i].Discription;

        HousePriceText.text = _HouseData.House_stats[i].price.ToString() + " $";

        if (i == 0)
        {

            HouseBuyBtn.SetActive(false);
            //WatchVideoBtn.SetActive(false);
            HouseSelectBtn.SetActive(true);
            HouseLockImage.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("house" + i) == 1)
        {
            //PriceText.text = "Owned";
            HouseBuyBtn.SetActive(false);
            //WatchVideoBtn.SetActive(false);

            HouseSelectBtn.SetActive(true);
            HouseLockImage.gameObject.SetActive(false);
        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            HouseBuyBtn.SetActive(true);
            HouseSelectBtn.SetActive(false);
            HouseLockImage.gameObject.SetActive(true);
        }
        HouseIndex = i;

    }

    public void SelectFood(int i)
    {
        FoodImage.sprite = _FoodData.Food_stats[i].Icon;

        FoodnameText.text = _FoodData.Food_stats[i].Name;
        FoodDiscription.text = _FoodData.Food_stats[i].Discription;

        FoodPriceText.text = _FoodData.Food_stats[i].price.ToString() + " $";

        if (i == 0)
        {

            FoodBuyBtn.SetActive(false);
            // WatchVideoBtn.SetActive(false);
            FoodSelectBtn.SetActive(true);
            FoodLockImage.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("food" + i) == 1)
        {
            // PriceText.text = "Owned";
            FoodBuyBtn.SetActive(false);
            // WatchVideoBtn.SetActive(false);

            FoodSelectBtn.SetActive(true);
            FoodLockImage.gameObject.SetActive(false);
        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            FoodBuyBtn.SetActive(true);
            FoodSelectBtn.SetActive(false);
            FoodLockImage.gameObject.SetActive(true);
        }
        FoodIndex = i;

    }

    public void SelectWheel(int i)
    {
        WheelImage.sprite = _WheelData.Wheel_stats[i].Icon;

        WheelnameText.text = _WheelData.Wheel_stats[i].Name;
        WheelDiscription.text = _WheelData.Wheel_stats[i].Discription;

        WheelPriceText.text = _WheelData.Wheel_stats[i].price.ToString() + " $";

        if (i == 0)
        {

            WheelBuyBtn.SetActive(false);
            // WatchVideoBtn.SetActive(false);
            WheelSelectBtn.SetActive(true);
            WheelLockImage.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("wheel" + i) == 1)
        {
            // PriceText.text = "Owned";
            WheelBuyBtn.SetActive(false);
            // WatchVideoBtn.SetActive(false);

            WheelSelectBtn.SetActive(true);
            WheelLockImage.gameObject.SetActive(false);
        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            WheelBuyBtn.SetActive(true);
            WheelSelectBtn.SetActive(false);
            WheelLockImage.gameObject.SetActive(true);
        }
        WheelIndex = i;

    }


    public void SelectHamester(int i)
    {

        nameText.text = _PlayerData.stats[i].Name;
        Health.text = _PlayerData.stats[i].Health.ToString();
        Damage.text = _PlayerData.stats[i].Damage.ToString();
        Defence.text = _PlayerData.stats[i].Defence.ToString();
        Speed.text = _PlayerData.stats[i].Speed.ToString();
        Discription.text = _PlayerData.stats[i].Discription;

        HealthSlider.fillAmount = _PlayerData.stats[i].Health / 100;
        DamageSlider.fillAmount = _PlayerData.stats[i].Damage / 100;
        DefenceSlider.fillAmount = _PlayerData.stats[i].Defence / 100;
        SpeedSlider.fillAmount = _PlayerData.stats[i].Speed / 100;

        PlayerImage.sprite = _PlayerData.stats[i].PlayerAvater;

        PriceText.text = _PlayerData.stats[i].Price.ToString() + " T";
        //DiamondPriceText.text = _PlayerData.stats[i].Diamonds.ToString() + " D";

        if (i == 0)
        {
           
            BuyToffeeBtn.SetActive(false);
           // WatchVideoBtn.SetActive(false);
            SelectBtn.SetActive(true);
            PlayerLock.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("players" + i) == 1)
        {
           
            BuyToffeeBtn.SetActive(false);
            BuyDiamondBtn.SetActive(false);
            // WatchVideoBtn.SetActive(false);
            PlayerLock.gameObject.SetActive(false);
            SelectBtn.SetActive(true);
        }
        else
        {
            // WatchVideoBtn.SetActive(true);
            if (i == 1 || i == 2 || i == 3)
            {
                BuyToffeeBtn.SetActive(true);
                BuyDiamondBtn.SetActive(false);
            }
            else if(i == 4 || i == 5 || i == 6)
            {
                BuyDiamondBtn.SetActive(true);
                BuyToffeeBtn.SetActive(false);
            }

            SelectBtn.SetActive(false);
            PlayerLock.gameObject.SetActive(true);
        }
        PlayerIndex = i;

      //  AudioManager.instance.PlaySound("button");
    }



    public void BuyPlayerBtn()
    {
        if (PlayerPrefs.GetInt("players" + PlayerIndex) == 0)
        {

            if (ToffeeCoins >= _PlayerData.stats[PlayerIndex].Price)
            {



                PlayerPrefs.SetInt("coins", ToffeeCoins - (_PlayerData.stats[PlayerIndex].Price));
                ToffeeCoins = PlayerPrefs.GetInt("coins");
                ToffeeCoinsText.text = PlayerPrefs.GetInt("coins").ToString() + " T";
                PlayerLock.gameObject.SetActive(false);
                BuyToffeeBtn.SetActive(false);
                //WatchVideoBtn.SetActive(false);
                SelectBtn.SetActive(true);
                PlayerPrefs.SetInt("players" + PlayerIndex, 1);
                PlayerPrefs.SetInt("player_bought", PlayerIndex);
            }
           
            else
            {
                NotEnoughCashPanel.SetActive(true);
            }
        }

        else if (PlayerPrefs.GetInt("players" + PlayerIndex) == 1)
        {


            PlayerPrefs.SetInt("player_bought", PlayerIndex);
        }
        //AudioManager.instance.PlaySound("button");

    }


    public void BuyPlayerDiamondBtn()
    {
        if (PlayerPrefs.GetInt("players" + PlayerIndex) == 0)
        {

            //if (DiamondCoins >= _PlayerData.stats[PlayerIndex].Diamonds)
            //{
            //    PlayerPrefs.SetInt("diamonds", DiamondCoins - (_PlayerData.stats[PlayerIndex].Diamonds));
            //    DiamondCoins = PlayerPrefs.GetInt("diamonds");
            //    DiamondCoinsText.text = PlayerPrefs.GetInt("diamonds").ToString() + " D";
            //    PlayerLock.gameObject.SetActive(false);
            //    BuyDiamondBtn.SetActive(false);
            //    //WatchVideoBtn.SetActive(false);
            //    SelectBtn.SetActive(true);
            //    PlayerPrefs.SetInt("players" + PlayerIndex, 1);
            //    PlayerPrefs.SetInt("player_bought", PlayerIndex);
            //}
            //else
            //{
            //    NotEnoughCashPanel.SetActive(true);
            //}
        }

        else if (PlayerPrefs.GetInt("players" + PlayerIndex) == 1)
        {


            PlayerPrefs.SetInt("player_bought", PlayerIndex);
        }
        //AudioManager.instance.PlaySound("button");

    }


    public void SelectPlayer()
    {
        

        PlayerPrefs.SetInt("players" + PlayerIndex,0);
       // Instantiate(_PlayerData.stats[PlayerIndex].HamsterPrefab, MenuSceneManager.Instance.PlayersSpwanPoint[PlayerIndex].transform.position, MenuSceneManager.Instance.PlayersSpwanPoint[PlayerIndex].transform.rotation);
        Instantiate(_PlayerData.stats[PlayerIndex].HamsterPrefab, MenuSceneManager.Instance.PlayersSpwanPoint[PlayerIndex].transform.position, MenuSceneManager.Instance.PlayersSpwanPoint[PlayerIndex].transform.rotation);


        PlayerPrefs.SetInt("hamster" + PlayerIndex, HamsterCount[PlayerIndex]++);


        Debug.Log(PlayerPrefs.GetInt("hamster" + PlayerIndex));

       
    }


    public void BuyBowlsBtn()
    {
        if (PlayerPrefs.GetInt("bowl" + BowlIndex) == 0)
        {

            if (ToffeeCoins >= _BowlData.Bowl_stats[BowlIndex].price)
            {



                PlayerPrefs.SetInt("coins", ToffeeCoins - (_BowlData.Bowl_stats[BowlIndex].price));
                ToffeeCoins = PlayerPrefs.GetInt("coins");
                ToffeeCoinsText.text = PlayerPrefs.GetInt("coins").ToString() + " $";
                BowlLockImage.gameObject.SetActive(false);
                BowlBuyBtn.SetActive(false);
                //WatchVideoBtn.SetActive(false);
                BowlSelectBtn.SetActive(true);
                PlayerPrefs.SetInt("bowl" + BowlIndex, 1);
               // PlayerPrefs.SetInt("player_bought", PlayerIndex);
            }
            else
            {
                NotEnoughCashPanel.SetActive(true);
            }
        }

       
        //AudioManager.instance.PlaySound("button");

    }

    public void SelectBowl()
    {

       MenuSceneManager.Instance.BowlMat.GetComponent<Renderer>().material  =   _BowlData.Bowl_stats[BowlIndex]._Mat;
       PlayerPrefs.SetInt("bowl", BowlIndex);
    }



    public void BuyHouseBtn()
    {
        if (PlayerPrefs.GetInt("house" + HouseIndex) == 0)
        {

            if (ToffeeCoins >= _HouseData.House_stats[HouseIndex].price)
            {



                PlayerPrefs.SetInt("coins", ToffeeCoins - (_HouseData.House_stats[HouseIndex].price));
                ToffeeCoins = PlayerPrefs.GetInt("coins");
                ToffeeCoinsText.text = PlayerPrefs.GetInt("coins").ToString() + " $";
                HouseLockImage.gameObject.SetActive(false);
                HouseBuyBtn.SetActive(false);
                //WatchVideoBtn.SetActive(false);
                HouseSelectBtn.SetActive(true);
                PlayerPrefs.SetInt("house" + HouseIndex, 1);
                //PlayerPrefs.SetInt("player_bought", PlayerIndex);
            }
            else
            {
                NotEnoughCashPanel.SetActive(true);
            }
        }


        //AudioManager.instance.PlaySound("button");

    }

    public void SelectHouse()
    {

        MenuSceneManager.Instance.HouseMat.GetComponent<Renderer>().material = _HouseData.House_stats[HouseIndex].Mat;
        PlayerPrefs.SetInt("house", HouseIndex);
    }


    public void BuyFoodBtn()
    {
        if (PlayerPrefs.GetInt("food" + FoodIndex) == 0)
        {

            if (ToffeeCoins >= _FoodData.Food_stats[FoodIndex].price)
            {



                PlayerPrefs.SetInt("coins", ToffeeCoins - (_FoodData.Food_stats[FoodIndex].price));
                ToffeeCoins = PlayerPrefs.GetInt("coins");
                ToffeeCoinsText.text = PlayerPrefs.GetInt("coins").ToString() + " $";
                FoodLockImage.gameObject.SetActive(false);
                FoodBuyBtn.SetActive(false);
                //WatchVideoBtn.SetActive(false);
                FoodSelectBtn.SetActive(true);
                PlayerPrefs.SetInt("food" + FoodIndex, 1);
                //PlayerPrefs.SetInt("player_bought", PlayerIndex);
            }
            else
            {
                NotEnoughCashPanel.SetActive(true);
            }
        }


        //AudioManager.instance.PlaySound("button");

    }
    public void SelectFood()
    {

        MenuSceneManager.Instance.FoodMat.GetComponent<Renderer>().material = _FoodData.Food_stats[FoodIndex].Mat;
        PlayerPrefs.SetInt("food", FoodIndex);
    }


    public void BuyWheelBtn()
    {
        if (PlayerPrefs.GetInt("wheel" + WheelIndex) == 0)
        {

            if (ToffeeCoins >= _WheelData.Wheel_stats[WheelIndex].price)
            {



                PlayerPrefs.SetInt("coins", ToffeeCoins - (_WheelData.Wheel_stats[WheelIndex].price));
                ToffeeCoins = PlayerPrefs.GetInt("coins");
                ToffeeCoinsText.text = PlayerPrefs.GetInt("coins").ToString() + " $";
                WheelLockImage.gameObject.SetActive(false);
                WheelBuyBtn.SetActive(false);
                //WatchVideoBtn.SetActive(false);
                WheelSelectBtn.SetActive(true);
                PlayerPrefs.SetInt("wheel" + WheelIndex, 1);
                //PlayerPrefs.SetInt("player_bought", PlayerIndex);
            }
            else
            {
                NotEnoughCashPanel.SetActive(true);
            }
        }


        //AudioManager.instance.PlaySound("button");

    }
    public void SelectWheel()
    {

        MenuSceneManager.Instance.WheelMat.GetComponent<Renderer>().material = _WheelData.Wheel_stats[WheelIndex].Mat;
        PlayerPrefs.SetInt("wheel", WheelIndex);
    }




    public void ShopBtn()
    {

        PlayerPrefs.SetInt("players" + 0, 1);
        PlayerPrefs.SetInt("bowl" + 0, 1);
        PlayerPrefs.SetInt("house" + 0, 1);
        PlayerPrefs.SetInt("food" + 0, 1);
        PlayerPrefs.SetInt("wheel" + 0, 1);

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
        //DiamondPriceText.text = _PlayerData.stats[0].Diamonds.ToString() + " D";

       

            BuyToffeeBtn.SetActive(false);
            // WatchVideoBtn.SetActive(false);
            SelectBtn.SetActive(true);
            PlayerLock.gameObject.SetActive(false);

        PlayerPanel.SetActive(true);
        BowlPanel.SetActive(false);
        FoodPanel.SetActive(false);
        WheelPanel.SetActive(false);
        HosuePanel.SetActive(false);


}

    }
