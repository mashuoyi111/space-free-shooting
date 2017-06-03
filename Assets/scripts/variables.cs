using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class variables{

	//player variables
	public static float playerSpeed=0.1f;
	public static float fireRate = 30f;
	public static float playerBulletSpeed = 0.5f;
	public static float playerBulletLife = 0.6f;
	public static float playerBulletSize = 0.3f;

	//enemy status variables
	public static float enemySpeed=0.12f;
	public static float enemyFireRate = 100f;

	//difficulty variables
	public static int MaxEnemies=3;
	public static float MinRespawnRate=8f;
	public static float IncreaseDifficultyInterval=15f;
	public static int currentLevel=1;
	public static int enemyKilledToGetUpgrade=1;
	public static int currentKilled=0;

	//score and time spend varibles;
	public static float startTime=Time.time;
	public static float gameTime=0f;
	public static float battlescore=0f;
	public static float score=0f;

	//game mode
	public static int gameMode=0;
}
