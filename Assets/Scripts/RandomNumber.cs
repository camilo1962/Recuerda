using UnityEngine;
using System.Collections;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class RandomNumber : MonoBehaviour
{
    public Text text;
   
    public Text scoreView;

    int cislo;
    string cisloD;
    float timer = 1;
    float timer2 = 1;
    int pokusy = 0;
    int rndCounter = 0;
    int numCounter = 3;
    int score = 0;
    int[] numbers = new int[20];
    int hadani;
    float cas = 2f;
    bool konec = true;
    int kolo = 3;
    int game = 0;

 
    void Update()
    {



        print(numCounter);
        if (numCounter != 0)
        {
            timer -= Time.deltaTime * cas;
            if (timer < 0)
            {
                rndNumber();
                numCounter--;
                timer = 1;
                timer2 = 1;
            }
        }
        else
        {
            timer2 -= Time.deltaTime * cas;
            if(timer2 < 0)
            {
                text.text = "";
            }
            
        }




    }

    public void rndNumber()
    {
        cislo = Random.Range(0, 9);
        cisloD = cislo.ToString();
        text.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        text.text = cisloD;
        
        numbers[rndCounter] = cislo;
        rndCounter++;

    }
    public void nula()
    {
        hadani = 0;
        kontrola();
    }
    public void jedna()
    {
        hadani = 1;
        kontrola();

    }
    public void dva()
    {
        hadani = 2;
        kontrola();

    }
    public void tri()
    {
        hadani = 3;
        kontrola();

    }
    public void ctyri()
    {
        hadani = 4;
        kontrola();

    }
    public void pet()
    {
        hadani = 5;
        kontrola();

    }
    public void sest()
    {
        hadani = 6;
        kontrola();

    }
    public void sedm()
    {
        hadani = 7;
        kontrola();

    }
    public void osm()
    {
        hadani = 8;
        kontrola();

    }
    public void devet()
    {
        hadani = 9;
        kontrola();

    }

    public void kontrola()
    {

        if (numbers[pokusy] == hadani)
        {
            

        }
        else
        {
            PlayerPrefs.SetInt("score", score);
            
            if(PlayerPrefs.GetInt("heightscore") < score)
            {
                PlayerPrefs.SetInt("heightscore", score);
            }
            game = PlayerPrefs.GetInt("game");
            game++;
            PlayerPrefs.SetInt("game", game);
            print(PlayerPrefs.GetInt("game"));
            if (PlayerPrefs.GetInt("game") % 6 == 0)
            {
              //  ShowAd();
            }
           
            
            loose();
        }
        


        pokusy++;

        if (pokusy == kolo)
        {
            
            vyhra();
        }

    }


    public void vyhra()
    {

        pokusy = 0;
        score++;
        scoreView.text = score.ToString();
        rndCounter = 0;
        numCounter = 0;


        if (score < 6)
        {
            cas = 3.4f;
            numCounter = 2;
            kolo = 2;
        }
        if (score >= 6 && score < 11)
        {
            cas = 3.2f;
            numCounter = 3;
            kolo = 3;

        }
        if (score >= 11 && score < 14)
        {
            cas = 6.4f;
            numCounter = 2;
            kolo = 2;

        }
        if (score >= 14 && score < 17)
        {
            cas = 2.5f;
            numCounter = 5;
            kolo = 5;

        }
        if (score >= 17 && score < 30)
        {
            cas = 5f;
            numCounter = 4;
            kolo = 4;

        }
        if(score >= 30 && score < 60)
        {
            cas = 3.3f;
            numCounter = 5;
            kolo = 5;

        } 
        if (score >= 60 && score < 100)
        {
            cas = 3.7f;
            numCounter = 6;
            kolo = 6;

        }
        if (score >= 100)
        {
            cas = 6f;
            numCounter = 6;
            kolo = 6;

        }
        //if (score >= 8 && score < 15)
        //{
        //    cas = 3f;
        //    numCounter = 5;
        //    kolo = 5;
        //}
        //if(score >=15)
        //{
        //    cas = 3.5f;
        //    numCounter = 5;
        //    kolo = 5;
        //}

    }
    
    public void loose()
    {
        print("Konec");
        SceneManager.LoadScene(3);
    }
    public int skore()
    {
        return score;
    }
}
