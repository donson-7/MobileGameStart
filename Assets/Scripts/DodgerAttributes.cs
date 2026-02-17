using UnityEngine;

public class DodgerAttributes
{
    int currHealth;
    int maxHealth;
    int currScore;

    public DodgerAttributes(int currHealth, int maxHealth, int currScore)
    {
        this.currHealth = currHealth;
        this.maxHealth = maxHealth;
        this.currScore = currScore;
    }


    public int getCurrHealth()
    {
        return currHealth;
    }

    public int getMaxCurrHealth()
    {
        return maxHealth;
    }

    public int getCurrScore()
    {
        return currScore;
    }


    public void setCurrHealth(int currHealth)
    {
        this.currHealth = currHealth;
    }

    public void setMaxHealth(int maxHealth)
    {
        this.maxHealth = maxHealth;
    }

    public void setCurrScore(int currScore)
    {
        this.currScore = currScore;
    }
}
