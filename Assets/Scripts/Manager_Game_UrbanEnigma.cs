using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.Serialization;

public class Manager_Game_UrbanEnigma : MonoBehaviour
{
	//[FormerlySerializedAs("onGameStart")]
	public UnityEvent onGameStart_UrbanEnigma;
	//FormerlySerializedAs("onGameFinish")]
	public UnityEvent onGameFinish_UrbanEnigma;
	//[FormerlySerializedAs("onNextClick")]
	public UnityEvent onNextClick_UrbanEnigma;
	//[FormerlySerializedAs("levels_data")]
	public LevelsData_UrbanEnigma levels_data_UrbanEnigma;
	public TMP_Text movesText_UrbanEnigma;


	private Level_UrbanEnigma current_level_data_UrbanEnigma;
	private int current_level_UrbanEnigma;
	private AllLevelsData all_levels_data_UrbanEnigma = new AllLevelsData();
	private bool game_running_UrbanEnigma = false;
	private int card_clicked_UrbanEnigma = 0;



	public static Manager_Game_UrbanEnigma instance;


	//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

	// Unused integer variables
	int unusedInt1 = 42;
	int unusedInt2 = -10;
	int unusedInt3 = 987;

	// Unused float variables
	float unusedFloat1 = 3.14f;
	float unusedFloat2 = -2.5f;
	float unusedFloat3 = 1.618f;

	// Unused boolean variables
	bool unusedBool1 = true;
	bool unusedBool2 = false;
	bool unusedBool3 = true;

	// Unused string variables
	string unusedString1 = "Hello, world!";
	string unusedString2 = "Unity is awesome";
	string unusedString3 = "Garbage variables";

	//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<




	private void Awake()
	{
		instance = this;

		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_Random_Logic = false;
		if (run_Random_Logic)
		{
			// Generate some random integers and floats
			int randomInt1 = UnityEngine.Random.Range(0, 100);
			int randomInt2 = UnityEngine.Random.Range(-50, 50);
			float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
			float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

			// Perform some random calculations
			int result1 = randomInt1 + randomInt2;
			float result2 = randomFloat1 * randomFloat2;

			// Create a random bool
			bool randomBool = UnityEngine.Random.value > 0.5f;

			// Concatenate some random strings
			string randomString1 = "Random String " + randomInt1;
			string randomString2 = "Another Random String " + randomFloat1;

			// Create a random GameObject
			GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

			// Add the random GameObject as a child of the current GameObject
			randomGameObject.transform.SetParent(transform);

			// Log the results
			Debug.Log($"UnusedMethodWithRandomLogic:");
			Debug.Log($"  randomInt1: {randomInt1}");
			Debug.Log($"  randomInt2: {randomInt2}");
			Debug.Log($"  randomFloat1: {randomFloat1}");
			Debug.Log($"  randomFloat2: {randomFloat2}");
			Debug.Log($"  result1: {result1}");
			Debug.Log($"  result2: {result2}");
			Debug.Log($"  randomBool: {randomBool}");
			Debug.Log($"  randomString1: {randomString1}");
			Debug.Log($"  randomString2: {randomString2}");
			Debug.Log($"  randomGameObject: {randomGameObject.name}");
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}

	private void Start()
	{
		//LoadLevelsSaved();

		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_Random_Logic = false;
		if (run_Random_Logic)
		{
			// Generate some random integers and floats
			int randomInt1 = UnityEngine.Random.Range(0, 100);
			int randomInt2 = UnityEngine.Random.Range(-50, 50);
			float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
			float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

			// Perform some random calculations
			int result1 = randomInt1 + randomInt2;
			float result2 = randomFloat1 * randomFloat2;

			// Create a random bool
			bool randomBool = UnityEngine.Random.value > 0.5f;

			// Concatenate some random strings
			string randomString1 = "Random String " + randomInt1;
			string randomString2 = "Another Random String " + randomFloat1;

			// Create a random GameObject
			GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

			// Add the random GameObject as a child of the current GameObject
			randomGameObject.transform.SetParent(transform);

			// Log the results
			Debug.Log($"UnusedMethodWithRandomLogic:");
			Debug.Log($"  randomInt1: {randomInt1}");
			Debug.Log($"  randomInt2: {randomInt2}");
			Debug.Log($"  randomFloat1: {randomFloat1}");
			Debug.Log($"  randomFloat2: {randomFloat2}");
			Debug.Log($"  result1: {result1}");
			Debug.Log($"  result2: {result2}");
			Debug.Log($"  randomBool: {randomBool}");
			Debug.Log($"  randomString1: {randomString1}");
			Debug.Log($"  randomString2: {randomString2}");
			Debug.Log($"  randomGameObject: {randomGameObject.name}");
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}

	public void StartLevel_UrbanEnigma(int level)
	{

		onGameStart_UrbanEnigma?.Invoke();

		current_level_data_UrbanEnigma = GetLevel_UrbanEnigma(level);
		current_level_UrbanEnigma = level;

		card_clicked_UrbanEnigma = 0;
		movesText_UrbanEnigma.text = card_clicked_UrbanEnigma.ToString();

		if (current_level_data_UrbanEnigma == null)
			return;

		for (int i = 0; i < current_level_data_UrbanEnigma.spritesLevel_UrbanEnigma.Length; i++)
		{
			CellGame_UrbanEnigma.on_set_icon_UrbanEnigma?.Invoke(current_level_data_UrbanEnigma.spritesLevel_UrbanEnigma[i], i + 1);
		}

		CellGame_UrbanEnigma.show_icon_UrbanEnigma?.Invoke(true);

		DelayStartGame_UrbanEnigma();


		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_Random_Logic = false;
		if (run_Random_Logic)
		{
			// Generate some random integers and floats
			int randomInt1 = UnityEngine.Random.Range(0, 100);
			int randomInt2 = UnityEngine.Random.Range(-50, 50);
			float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
			float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

			// Perform some random calculations
			int result1 = randomInt1 + randomInt2;
			float result2 = randomFloat1 * randomFloat2;

			// Create a random bool
			bool randomBool = UnityEngine.Random.value > 0.5f;

			// Concatenate some random strings
			string randomString1 = "Random String " + randomInt1;
			string randomString2 = "Another Random String " + randomFloat1;

			// Create a random GameObject
			GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

			// Add the random GameObject as a child of the current GameObject
			randomGameObject.transform.SetParent(transform);

			// Log the results
			Debug.Log($"UnusedMethodWithRandomLogic:");
			Debug.Log($"  randomInt1: {randomInt1}");
			Debug.Log($"  randomInt2: {randomInt2}");
			Debug.Log($"  randomFloat1: {randomFloat1}");
			Debug.Log($"  randomFloat2: {randomFloat2}");
			Debug.Log($"  result1: {result1}");
			Debug.Log($"  result2: {result2}");
			Debug.Log($"  randomBool: {randomBool}");
			Debug.Log($"  randomString1: {randomString1}");
			Debug.Log($"  randomString2: {randomString2}");
			Debug.Log($"  randomGameObject: {randomGameObject.name}");
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}

	private Level_UrbanEnigma GetLevel_UrbanEnigma(int level)
	{
		foreach (var item in levels_data_UrbanEnigma.levels_UrbanEnigma)
		{
			if (item.level_UrbanEnigma == level)
				return item;
		}

		return null;


		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_Random_Logic = false;
		if (run_Random_Logic)
		{
			// Generate some random integers and floats
			int randomInt1 = UnityEngine.Random.Range(0, 100);
			int randomInt2 = UnityEngine.Random.Range(-50, 50);
			float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
			float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

			// Perform some random calculations
			int result1 = randomInt1 + randomInt2;
			float result2 = randomFloat1 * randomFloat2;

			// Create a random bool
			bool randomBool = UnityEngine.Random.value > 0.5f;

			// Concatenate some random strings
			string randomString1 = "Random String " + randomInt1;
			string randomString2 = "Another Random String " + randomFloat1;

			// Create a random GameObject
			GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

			// Add the random GameObject as a child of the current GameObject
			randomGameObject.transform.SetParent(transform);

			// Log the results
			Debug.Log($"UnusedMethodWithRandomLogic:");
			Debug.Log($"  randomInt1: {randomInt1}");
			Debug.Log($"  randomInt2: {randomInt2}");
			Debug.Log($"  randomFloat1: {randomFloat1}");
			Debug.Log($"  randomFloat2: {randomFloat2}");
			Debug.Log($"  result1: {result1}");
			Debug.Log($"  result2: {result2}");
			Debug.Log($"  randomBool: {randomBool}");
			Debug.Log($"  randomString1: {randomString1}");
			Debug.Log($"  randomString2: {randomString2}");
			Debug.Log($"  randomGameObject: {randomGameObject.name}");
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}


	private async void DelayStartGame_UrbanEnigma()
	{
		await Task.Delay(TimeSpan.FromSeconds(2));

		game_running_UrbanEnigma = true;
		CellGame_UrbanEnigma.show_icon_UrbanEnigma?.Invoke(false);


		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_Random_Logic = false;
		if (run_Random_Logic)
		{
			// Generate some random integers and floats
			int randomInt1 = UnityEngine.Random.Range(0, 100);
			int randomInt2 = UnityEngine.Random.Range(-50, 50);
			float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
			float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

			// Perform some random calculations
			int result1 = randomInt1 + randomInt2;
			float result2 = randomFloat1 * randomFloat2;

			// Create a random bool
			bool randomBool = UnityEngine.Random.value > 0.5f;

			// Concatenate some random strings
			string randomString1 = "Random String " + randomInt1;
			string randomString2 = "Another Random String " + randomFloat1;

			// Create a random GameObject
			GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

			// Add the random GameObject as a child of the current GameObject
			randomGameObject.transform.SetParent(transform);

			// Log the results
			Debug.Log($"UnusedMethodWithRandomLogic:");
			Debug.Log($"  randomInt1: {randomInt1}");
			Debug.Log($"  randomInt2: {randomInt2}");
			Debug.Log($"  randomFloat1: {randomFloat1}");
			Debug.Log($"  randomFloat2: {randomFloat2}");
			Debug.Log($"  result1: {result1}");
			Debug.Log($"  result2: {result2}");
			Debug.Log($"  randomBool: {randomBool}");
			Debug.Log($"  randomString1: {randomString1}");
			Debug.Log($"  randomString2: {randomString2}");
			Debug.Log($"  randomGameObject: {randomGameObject.name}");
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

	}













	private CellGame_UrbanEnigma first_card_UrbanEnigma, second_card_UrbanEnigma;
	private bool is_firstCard_UrbanEnigma = false;
	private bool lock_interaction_UrbanEnigma = false;

	public void CardClicked_UrbanEnigma(CellGame_UrbanEnigma cell)
	{
		if (lock_interaction_UrbanEnigma || cell.is_showing_icon_UrbanEnigma || !game_running_UrbanEnigma) return;
		lock_interaction_UrbanEnigma = true;

		cell.Show_Icon_UrbanEnigma(true);

		if (!is_firstCard_UrbanEnigma)
		{
			is_firstCard_UrbanEnigma = true;
			first_card_UrbanEnigma = cell;
			lock_interaction_UrbanEnigma = false;

			card_clicked_UrbanEnigma++;
			movesText_UrbanEnigma.text = card_clicked_UrbanEnigma.ToString();
		}
		else
		{
			second_card_UrbanEnigma = cell;
			CheckCards_UrbanEnigma();

			card_clicked_UrbanEnigma++;
			movesText_UrbanEnigma.text = card_clicked_UrbanEnigma.ToString();
		}


		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_Random_Logic = false;
		if (run_Random_Logic)
		{
			// Generate some random integers and floats
			int randomInt1 = UnityEngine.Random.Range(0, 100);
			int randomInt2 = UnityEngine.Random.Range(-50, 50);
			float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
			float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

			// Perform some random calculations
			int result1 = randomInt1 + randomInt2;
			float result2 = randomFloat1 * randomFloat2;

			// Create a random bool
			bool randomBool = UnityEngine.Random.value > 0.5f;

			// Concatenate some random strings
			string randomString1 = "Random String " + randomInt1;
			string randomString2 = "Another Random String " + randomFloat1;

			// Create a random GameObject
			GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

			// Add the random GameObject as a child of the current GameObject
			randomGameObject.transform.SetParent(transform);

			// Log the results
			Debug.Log($"UnusedMethodWithRandomLogic:");
			Debug.Log($"  randomInt1: {randomInt1}");
			Debug.Log($"  randomInt2: {randomInt2}");
			Debug.Log($"  randomFloat1: {randomFloat1}");
			Debug.Log($"  randomFloat2: {randomFloat2}");
			Debug.Log($"  result1: {result1}");
			Debug.Log($"  result2: {result2}");
			Debug.Log($"  randomBool: {randomBool}");
			Debug.Log($"  randomString1: {randomString1}");
			Debug.Log($"  randomString2: {randomString2}");
			Debug.Log($"  randomGameObject: {randomGameObject.name}");
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}

	private async void CheckCards_UrbanEnigma()
	{


		if (first_card_UrbanEnigma.icon_for_cell_UrbanEnigma.ToString() == second_card_UrbanEnigma.icon_for_cell_UrbanEnigma.ToString())
		{
			is_firstCard_UrbanEnigma = false;
		}
		else
		{
			await Task.Delay(TimeSpan.FromSeconds(1));
			first_card_UrbanEnigma.Show_Icon_UrbanEnigma(false);
			second_card_UrbanEnigma.Show_Icon_UrbanEnigma(false);
			is_firstCard_UrbanEnigma = false;
		}

		lock_interaction_UrbanEnigma = false;
		CheckIfGameFinishes_UrbanEnigma();


		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_Random_Logic = false;
		if (run_Random_Logic)
		{
			// Generate some random integers and floats
			int randomInt1 = UnityEngine.Random.Range(0, 100);
			int randomInt2 = UnityEngine.Random.Range(-50, 50);
			float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
			float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

			// Perform some random calculations
			int result1 = randomInt1 + randomInt2;
			float result2 = randomFloat1 * randomFloat2;

			// Create a random bool
			bool randomBool = UnityEngine.Random.value > 0.5f;

			// Concatenate some random strings
			string randomString1 = "Random String " + randomInt1;
			string randomString2 = "Another Random String " + randomFloat1;

			// Create a random GameObject
			GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

			// Add the random GameObject as a child of the current GameObject
			randomGameObject.transform.SetParent(transform);

			// Log the results
			Debug.Log($"UnusedMethodWithRandomLogic:");
			Debug.Log($"  randomInt1: {randomInt1}");
			Debug.Log($"  randomInt2: {randomInt2}");
			Debug.Log($"  randomFloat1: {randomFloat1}");
			Debug.Log($"  randomFloat2: {randomFloat2}");
			Debug.Log($"  result1: {result1}");
			Debug.Log($"  result2: {result2}");
			Debug.Log($"  randomBool: {randomBool}");
			Debug.Log($"  randomString1: {randomString1}");
			Debug.Log($"  randomString2: {randomString2}");
			Debug.Log($"  randomGameObject: {randomGameObject.name}");
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}

	private async void CheckIfGameFinishes_UrbanEnigma()
	{
		bool all_cards_found = true;

		CellGame_UrbanEnigma.isNotFound?.Invoke(() => { all_cards_found = false; });
		// foreach (var item in cells__UrbanEnigma)
		// {
		//     if (!item.is_showing_icon_UrbanEnigma)
		//         all_cards_found = false;
		// }

		if (all_cards_found)
		{
			onGameFinish_UrbanEnigma?.Invoke();
			Debug.Log("Game Finished");
		}



		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_Random_Logic = false;
		if (run_Random_Logic)
		{
			// Generate some random integers and floats
			int randomInt1 = UnityEngine.Random.Range(0, 100);
			int randomInt2 = UnityEngine.Random.Range(-50, 50);
			float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
			float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

			// Perform some random calculations
			int result1 = randomInt1 + randomInt2;
			float result2 = randomFloat1 * randomFloat2;

			// Create a random bool
			bool randomBool = UnityEngine.Random.value > 0.5f;

			// Concatenate some random strings
			string randomString1 = "Random String " + randomInt1;
			string randomString2 = "Another Random String " + randomFloat1;

			// Create a random GameObject
			GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

			// Add the random GameObject as a child of the current GameObject
			randomGameObject.transform.SetParent(transform);

			// Log the results
			Debug.Log($"UnusedMethodWithRandomLogic:");
			Debug.Log($"  randomInt1: {randomInt1}");
			Debug.Log($"  randomInt2: {randomInt2}");
			Debug.Log($"  randomFloat1: {randomFloat1}");
			Debug.Log($"  randomFloat2: {randomFloat2}");
			Debug.Log($"  result1: {result1}");
			Debug.Log($"  result2: {result2}");
			Debug.Log($"  randomBool: {randomBool}");
			Debug.Log($"  randomString1: {randomString1}");
			Debug.Log($"  randomString2: {randomString2}");
			Debug.Log($"  randomGameObject: {randomGameObject.name}");
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}

	private void LevelFinish_UrbanEnigma()
	{
		CheckLevelUnlocked();
		FetchDataLevels();


		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_Random_Logic = false;
		if (run_Random_Logic)
		{
			// Generate some random integers and floats
			int randomInt1 = UnityEngine.Random.Range(0, 100);
			int randomInt2 = UnityEngine.Random.Range(-50, 50);
			float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
			float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

			// Perform some random calculations
			int result1 = randomInt1 + randomInt2;
			float result2 = randomFloat1 * randomFloat2;

			// Create a random bool
			bool randomBool = UnityEngine.Random.value > 0.5f;

			// Concatenate some random strings
			string randomString1 = "Random String " + randomInt1;
			string randomString2 = "Another Random String " + randomFloat1;

			// Create a random GameObject
			GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

			// Add the random GameObject as a child of the current GameObject
			randomGameObject.transform.SetParent(transform);

			// Log the results
			Debug.Log($"UnusedMethodWithRandomLogic:");
			Debug.Log($"  randomInt1: {randomInt1}");
			Debug.Log($"  randomInt2: {randomInt2}");
			Debug.Log($"  randomFloat1: {randomFloat1}");
			Debug.Log($"  randomFloat2: {randomFloat2}");
			Debug.Log($"  result1: {result1}");
			Debug.Log($"  result2: {result2}");
			Debug.Log($"  randomBool: {randomBool}");
			Debug.Log($"  randomString1: {randomString1}");
			Debug.Log($"  randomString2: {randomString2}");
			Debug.Log($"  randomGameObject: {randomGameObject.name}");
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

	}
	public void NextClick_UrbanEnigma()
	{
		if (current_level_UrbanEnigma < 12)
		{
			current_level_UrbanEnigma++;
		}
		else
		{
			current_level_UrbanEnigma = 1;

		}
		StartLevel_UrbanEnigma(current_level_UrbanEnigma);

		onNextClick_UrbanEnigma?.Invoke();
		// LevelFinish_UrbanEnigma();


		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_Random_Logic = false;
		if (run_Random_Logic)
		{
			// Generate some random integers and floats
			int randomInt1 = UnityEngine.Random.Range(0, 100);
			int randomInt2 = UnityEngine.Random.Range(-50, 50);
			float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
			float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

			// Perform some random calculations
			int result1 = randomInt1 + randomInt2;
			float result2 = randomFloat1 * randomFloat2;

			// Create a random bool
			bool randomBool = UnityEngine.Random.value > 0.5f;

			// Concatenate some random strings
			string randomString1 = "Random String " + randomInt1;
			string randomString2 = "Another Random String " + randomFloat1;

			// Create a random GameObject
			GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

			// Add the random GameObject as a child of the current GameObject
			randomGameObject.transform.SetParent(transform);

			// Log the results
			Debug.Log($"UnusedMethodWithRandomLogic:");
			Debug.Log($"  randomInt1: {randomInt1}");
			Debug.Log($"  randomInt2: {randomInt2}");
			Debug.Log($"  randomFloat1: {randomFloat1}");
			Debug.Log($"  randomFloat2: {randomFloat2}");
			Debug.Log($"  result1: {result1}");
			Debug.Log($"  result2: {result2}");
			Debug.Log($"  randomBool: {randomBool}");
			Debug.Log($"  randomString1: {randomString1}");
			Debug.Log($"  randomString2: {randomString2}");
			Debug.Log($"  randomGameObject: {randomGameObject.name}");
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

	}

	private void OnDestroy()
	{
		//SaveDataLevels();


		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_Random_Logic = false;
		if (run_Random_Logic)
		{
			// Generate some random integers and floats
			int randomInt1 = UnityEngine.Random.Range(0, 100);
			int randomInt2 = UnityEngine.Random.Range(-50, 50);
			float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
			float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

			// Perform some random calculations
			int result1 = randomInt1 + randomInt2;
			float result2 = randomFloat1 * randomFloat2;

			// Create a random bool
			bool randomBool = UnityEngine.Random.value > 0.5f;

			// Concatenate some random strings
			string randomString1 = "Random String " + randomInt1;
			string randomString2 = "Another Random String " + randomFloat1;

			// Create a random GameObject
			GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

			// Add the random GameObject as a child of the current GameObject
			randomGameObject.transform.SetParent(transform);

			// Log the results
			Debug.Log($"UnusedMethodWithRandomLogic:");
			Debug.Log($"  randomInt1: {randomInt1}");
			Debug.Log($"  randomInt2: {randomInt2}");
			Debug.Log($"  randomFloat1: {randomFloat1}");
			Debug.Log($"  randomFloat2: {randomFloat2}");
			Debug.Log($"  result1: {result1}");
			Debug.Log($"  result2: {result2}");
			Debug.Log($"  randomBool: {randomBool}");
			Debug.Log($"  randomString1: {randomString1}");
			Debug.Log($"  randomString2: {randomString2}");
			Debug.Log($"  randomGameObject: {randomGameObject.name}");
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}

	private void SaveDataLevels()
	{
		var allData = new JSONObject("[]");



		var JsonObj_Data = new JSONObject(JsonUtility.ToJson(all_levels_data_UrbanEnigma));
		allData.AddField("Levels", JsonObj_Data);

		PlayerPrefs.SetString("LevelsData", allData.ToString());


		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_Random_Logic = false;
		if (run_Random_Logic)
		{
			// Generate some random integers and floats
			int randomInt1 = UnityEngine.Random.Range(0, 100);
			int randomInt2 = UnityEngine.Random.Range(-50, 50);
			float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
			float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

			// Perform some random calculations
			int result1 = randomInt1 + randomInt2;
			float result2 = randomFloat1 * randomFloat2;

			// Create a random bool
			bool randomBool = UnityEngine.Random.value > 0.5f;

			// Concatenate some random strings
			string randomString1 = "Random String " + randomInt1;
			string randomString2 = "Another Random String " + randomFloat1;

			// Create a random GameObject
			GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

			// Add the random GameObject as a child of the current GameObject
			randomGameObject.transform.SetParent(transform);

			// Log the results
			Debug.Log($"UnusedMethodWithRandomLogic:");
			Debug.Log($"  randomInt1: {randomInt1}");
			Debug.Log($"  randomInt2: {randomInt2}");
			Debug.Log($"  randomFloat1: {randomFloat1}");
			Debug.Log($"  randomFloat2: {randomFloat2}");
			Debug.Log($"  result1: {result1}");
			Debug.Log($"  result2: {result2}");
			Debug.Log($"  randomBool: {randomBool}");
			Debug.Log($"  randomString1: {randomString1}");
			Debug.Log($"  randomString2: {randomString2}");
			Debug.Log($"  randomGameObject: {randomGameObject.name}");
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}

	private void LoadLevelsSaved()
	{
		if (PlayerPrefs.HasKey("LevelsData"))
		{
			var data_loaded = PlayerPrefs.GetString("LevelsData");
			var allData = new JSONObject(data_loaded);


			if (allData.HasField("Levels"))
			{
				all_levels_data_UrbanEnigma = JsonUtility.FromJson<AllLevelsData>(allData["Levels"].ToString());
			}


			if (all_levels_data_UrbanEnigma.levels.Count == 0)
			{
				LevelData_UrbanEnigma level_d = new LevelData_UrbanEnigma();
				level_d.level = 1;

				all_levels_data_UrbanEnigma.levels.Add(level_d);
			}

			CheckLevelUnlocked();
			FetchDataLevels();
		}
		else
		{
			LevelData_UrbanEnigma level_d = new LevelData_UrbanEnigma();
			level_d.level = 1;

			all_levels_data_UrbanEnigma.levels.Add(level_d);

			CheckLevelUnlocked();
			FetchDataLevels();
		}


		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_Random_Logic = false;
		if (run_Random_Logic)
		{
			// Generate some random integers and floats
			int randomInt1 = UnityEngine.Random.Range(0, 100);
			int randomInt2 = UnityEngine.Random.Range(-50, 50);
			float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
			float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

			// Perform some random calculations
			int result1 = randomInt1 + randomInt2;
			float result2 = randomFloat1 * randomFloat2;

			// Create a random bool
			bool randomBool = UnityEngine.Random.value > 0.5f;

			// Concatenate some random strings
			string randomString1 = "Random String " + randomInt1;
			string randomString2 = "Another Random String " + randomFloat1;

			// Create a random GameObject
			GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

			// Add the random GameObject as a child of the current GameObject
			randomGameObject.transform.SetParent(transform);

			// Log the results
			Debug.Log($"UnusedMethodWithRandomLogic:");
			Debug.Log($"  randomInt1: {randomInt1}");
			Debug.Log($"  randomInt2: {randomInt2}");
			Debug.Log($"  randomFloat1: {randomFloat1}");
			Debug.Log($"  randomFloat2: {randomFloat2}");
			Debug.Log($"  result1: {result1}");
			Debug.Log($"  result2: {result2}");
			Debug.Log($"  randomBool: {randomBool}");
			Debug.Log($"  randomString1: {randomString1}");
			Debug.Log($"  randomString2: {randomString2}");
			Debug.Log($"  randomGameObject: {randomGameObject.name}");
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

	}

	private void CheckLevelUnlocked()
	{
		if (all_levels_data_UrbanEnigma.levels.Count == 12) return;

		bool unlock_next = false;



		if (unlock_next)
		{
			LevelData_UrbanEnigma level_n = new LevelData_UrbanEnigma();
			level_n.level = all_levels_data_UrbanEnigma.levels[all_levels_data_UrbanEnigma.levels.Count - 1].level + 1;


			all_levels_data_UrbanEnigma.levels.Add(level_n);
		}


		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_Random_Logic = false;
		if (run_Random_Logic)
		{
			// Generate some random integers and floats
			int randomInt1 = UnityEngine.Random.Range(0, 100);
			int randomInt2 = UnityEngine.Random.Range(-50, 50);
			float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
			float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

			// Perform some random calculations
			int result1 = randomInt1 + randomInt2;
			float result2 = randomFloat1 * randomFloat2;

			// Create a random bool
			bool randomBool = UnityEngine.Random.value > 0.5f;

			// Concatenate some random strings
			string randomString1 = "Random String " + randomInt1;
			string randomString2 = "Another Random String " + randomFloat1;

			// Create a random GameObject
			GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

			// Add the random GameObject as a child of the current GameObject
			randomGameObject.transform.SetParent(transform);

			// Log the results
			Debug.Log($"UnusedMethodWithRandomLogic:");
			Debug.Log($"  randomInt1: {randomInt1}");
			Debug.Log($"  randomInt2: {randomInt2}");
			Debug.Log($"  randomFloat1: {randomFloat1}");
			Debug.Log($"  randomFloat2: {randomFloat2}");
			Debug.Log($"  result1: {result1}");
			Debug.Log($"  result2: {result2}");
			Debug.Log($"  randomBool: {randomBool}");
			Debug.Log($"  randomString1: {randomString1}");
			Debug.Log($"  randomString2: {randomString2}");
			Debug.Log($"  randomGameObject: {randomGameObject.name}");
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

	}

	private void FetchDataLevels()
	{
		// foreach (var item in all_levels_data.levels)
		// {
		//     Cell_UrbanEnigma.set_level?.Invoke(item);
		// }


		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_Random_Logic = false;
		if (run_Random_Logic)
		{
			// Generate some random integers and floats
			int randomInt1 = UnityEngine.Random.Range(0, 100);
			int randomInt2 = UnityEngine.Random.Range(-50, 50);
			float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
			float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

			// Perform some random calculations
			int result1 = randomInt1 + randomInt2;
			float result2 = randomFloat1 * randomFloat2;

			// Create a random bool
			bool randomBool = UnityEngine.Random.value > 0.5f;

			// Concatenate some random strings
			string randomString1 = "Random String " + randomInt1;
			string randomString2 = "Another Random String " + randomFloat1;

			// Create a random GameObject
			GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

			// Add the random GameObject as a child of the current GameObject
			randomGameObject.transform.SetParent(transform);

			// Log the results
			Debug.Log($"UnusedMethodWithRandomLogic:");
			Debug.Log($"  randomInt1: {randomInt1}");
			Debug.Log($"  randomInt2: {randomInt2}");
			Debug.Log($"  randomFloat1: {randomFloat1}");
			Debug.Log($"  randomFloat2: {randomFloat2}");
			Debug.Log($"  result1: {result1}");
			Debug.Log($"  result2: {result2}");
			Debug.Log($"  randomBool: {randomBool}");
			Debug.Log($"  randomString1: {randomString1}");
			Debug.Log($"  randomString2: {randomString2}");
			Debug.Log($"  randomGameObject: {randomGameObject.name}");
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

	}

	public void PlayTheHighestLevel()
	{
		StartLevel_UrbanEnigma(all_levels_data_UrbanEnigma.levels[all_levels_data_UrbanEnigma.levels.Count - 1].level);



		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_Random_Logic = false;
		if (run_Random_Logic)
		{
			// Generate some random integers and floats
			int randomInt1 = UnityEngine.Random.Range(0, 100);
			int randomInt2 = UnityEngine.Random.Range(-50, 50);
			float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
			float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

			// Perform some random calculations
			int result1 = randomInt1 + randomInt2;
			float result2 = randomFloat1 * randomFloat2;

			// Create a random bool
			bool randomBool = UnityEngine.Random.value > 0.5f;

			// Concatenate some random strings
			string randomString1 = "Random String " + randomInt1;
			string randomString2 = "Another Random String " + randomFloat1;

			// Create a random GameObject
			GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

			// Add the random GameObject as a child of the current GameObject
			randomGameObject.transform.SetParent(transform);

			// Log the results
			Debug.Log($"UnusedMethodWithRandomLogic:");
			Debug.Log($"  randomInt1: {randomInt1}");
			Debug.Log($"  randomInt2: {randomInt2}");
			Debug.Log($"  randomFloat1: {randomFloat1}");
			Debug.Log($"  randomFloat2: {randomFloat2}");
			Debug.Log($"  result1: {result1}");
			Debug.Log($"  result2: {result2}");
			Debug.Log($"  randomBool: {randomBool}");
			Debug.Log($"  randomString1: {randomString1}");
			Debug.Log($"  randomString2: {randomString2}");
			Debug.Log($"  randomGameObject: {randomGameObject.name}");
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}





	//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<


	void UnusedMethod1()
	{
		int randomInt = UnityEngine.Random.Range(0, 100);
		float randomFloat = UnityEngine.Random.Range(-10f, 10f);
		bool randomBool = UnityEngine.Random.value > 0.5f;

		Debug.Log($"UnusedMethod1: randomInt={randomInt}, randomFloat={randomFloat}, randomBool={randomBool}");
	}

	int UnusedMethod2(int param1, float param2)
	{
		int result = param1 * Mathf.FloorToInt(param2);
		Debug.Log($"UnusedMethod2: param1={param1}, param2={param2}, result={result}");
		return result;
	}

	bool UnusedMethod3(string param1)
	{
		bool result = param1.Length > 5;
		Debug.Log($"UnusedMethod3: param1='{param1}', result={result}");
		return result;
	}

	void UnusedMethod4(GameObject param1, Transform param2)
	{
		if (param1 != null && param2 != null)
		{
			param1.transform.position = param2.position + Vector3.up * UnityEngine.Random.Range(1f, 5f);
			Debug.Log($"UnusedMethod4: param1={param1.name}, param2={param2.name}, new position={param1.transform.position}");
		}
		else
		{
			Debug.Log("UnusedMethod4: One or both parameters are null.");
		}
	}

	float UnusedMethod5(int[] param1, float[] param2)
	{
		float result = 0f;
		for (int i = 0; i < param1.Length; i++)
		{
			result += param1[i] * param2[i];
		}
		Debug.Log($"UnusedMethod5: result={result}");
		return result;
	}
	void UnusedMethod7()
{
    Debug.Log("UnusedMethod7: This method does nothing.");
}

int UnusedMethod8(bool param1)
{
    int result = param1 ? 42 : -42;
    Debug.Log($"UnusedMethod8: param1={param1}, result={result}");
    return result;
}

bool UnusedMethod9(string param1, string param2)
{
    bool result = !string.IsNullOrEmpty(param1) && !string.IsNullOrEmpty(param2) && param1.Equals(param2);
    Debug.Log($"UnusedMethod9: param1='{param1}', param2='{param2}', result={result}");
    return result;
}

void UnusedMethod10(GameObject param1)
{
    if (param1 != null)
    {
        param1.SetActive(!param1.activeSelf);
        Debug.Log($"UnusedMethod10: param1={param1.name}, new state={param1.activeSelf}");
    }
    else
    {
        Debug.Log("UnusedMethod10: Parameter is null.");
    }
}

	//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<


}

[Serializable]
public class AllLevelsData
{
	public List<LevelData_UrbanEnigma> levels = new List<LevelData_UrbanEnigma>();

	//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

	// Unused integer variables
	int unusedInt1 = 42;
	int unusedInt2 = -10;
	int unusedInt3 = 987;

	// Unused float variables
	float unusedFloat1 = 3.14f;
	float unusedFloat2 = -2.5f;
	float unusedFloat3 = 1.618f;

	// Unused boolean variables
	bool unusedBool1 = true;
	bool unusedBool2 = false;
	bool unusedBool3 = true;

	// Unused string variables
	string unusedString1 = "Hello, world!";
	string unusedString2 = "Unity is awesome";
	string unusedString3 = "Garbage variables";

	//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
}


