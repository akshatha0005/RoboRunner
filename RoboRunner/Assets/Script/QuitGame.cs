
using UnityEngine;
using System.Collections;
public class QuitGame : IMenuCommand
{
	private MainMenu mainMenu;
	//Quit Game
	public QuitGame(MainMenu mainMenu)
	{
		this.mainMenu = mainMenu;
	}

	//Action performed after quitting
	public void DoAction(MenuManager menuManager){
		mainMenu.QuitGame (menuManager);
	}
}


