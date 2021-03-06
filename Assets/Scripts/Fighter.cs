﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter {
    public int menuX;
    public int menuY;
    public int team;
    public float health;
    public int xPos;
    public int zPos;
    public int range;
    public float attackStat;
    public float defenseStat;
    public string fighterName;
    public int model;
    //0 beats 2, 1 beats 0, 2 beats 1
    public int type;

	public Fighter(int t,int menuSelectX,int menuSelectY)
    {
        menuX = menuSelectX;
        menuY = menuSelectY;
        
        switch (menuSelectY)
        {
            case 0:
                switch (menuSelectX)
                {
                    case 0:
                        team = t;
                        model = 0;
                        range = 5;
                        xPos = menuSelectX;
                        zPos = menuSelectY;
                        attackStat = 1;
                        defenseStat = 1;
                        health = 1;
                        type = 0;
                        fighterName = "GFK";
                        break;
                    case 1:
                        team = t;
                        model = 1;
                        range = 5;
                        xPos = menuSelectX;
                        zPos = menuSelectY;
                        attackStat = 1;
                        defenseStat = 1;
                        health = 1;
                        type = 0;
                        fighterName = "Danny";
                        break;
                    case 2:
                        team = t;
                        model = 2;
                        range = 5;
                        xPos = menuSelectX;
                        zPos = menuSelectY;
                        attackStat = 1.5f;
                        defenseStat = .5f;
                        health = 1;
                        type = 1;
                        fighterName = "Slick Rick";
                        break;
                    case 3:
                        team = t;
                        model = 3;
                        range = 5;
                        xPos = menuSelectX;
                        zPos = menuSelectY;
                        attackStat = 1.5f;
                        defenseStat = .5f;
                        health = 1;
                        type = 1;
                        fighterName = "Ice-T";
                        break;
                }
                break;
            case 1:
                switch (menuSelectX)
                {
                    case 0:
                        team = t;
                        model = 4;
                        range = 10;
                        xPos = menuSelectX;
                        zPos = menuSelectY;
                        attackStat = 1;
                        defenseStat = .5f;
                        health = 1;
                        type = 1;
                        fighterName = "Method Man";
                        break;
                    case 1:
                        team = t;
                        model = 5;
                        range = 10;
                        xPos = menuSelectX;
                        zPos = menuSelectY;
                        attackStat = 1;
                        defenseStat = .5f;
                        health = 1;
                        type = 2;
                        fighterName = "X-Zibit";
                        break;
                    case 2:
                        team = t;
                        model = 6;
                        range = 3;
                        xPos = menuSelectX;
                        zPos = menuSelectY;
                        attackStat = .5f;
                        defenseStat = 2;
                        health = 1;
                        type = 2;
                        fighterName = "Busta";
                        break;
                    case 3:
                        team = t;
                        model = 7;
                        range = 3;
                        xPos = menuSelectX;
                        zPos = menuSelectY;
                        attackStat = .5f;
                        defenseStat = 2;
                        health = 1;
                        type = 2;
                        fighterName = "Ludacris";
                        break;
                }
                break;
                // attributes instantiated on character select
        }
        //Pos set to start square
        //
    }
    public void Formation(int augX, int augY)
    {
        xPos += augX;
        zPos += augY;
        //alter gamemanager objects too
    }
}
