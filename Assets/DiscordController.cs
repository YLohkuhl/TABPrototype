using Discord;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GlobalVariables;

public class DiscordController : MonoBehaviour
{
	public Discord.Discord discord;
	public static ActivityManager activityManager;

	// Use this for initialization
	void Start()
	{
		try { discord = new Discord.Discord(1059531918925889728, (ulong)CreateFlags.NoRequireDiscord); } 
		catch (ResultException) { Debug.LogWarning("Discord is most likely to be closed! Not initializing.."); }
		if (discord != null)
		{
			activityManager = discord.GetActivityManager();

			var activity = new Activity
			{
				State = "Main Menu",
				Details = "Looking around? About to play?",
				Assets =
				{
					LargeImage = "icon",
					LargeText = $"TAB ({versionNumber})"
				}
			};

			activityManager.UpdateActivity(activity, (res) =>
			{
				if (res == Result.Ok)
				{
					Debug.Log("Discord Presence Initialized!");
				}
			});
		}
	}

	// Update is called once per frame
	void Update()
	{
		if (discord != null)
			try { discord.RunCallbacks(); }
			catch (ResultException) { }
	}
}
