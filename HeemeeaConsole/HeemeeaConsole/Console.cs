using System;
using Il2Cpp;
using MelonLoader;
using UnityEngine;

namespace AC
{
	public class Hack : MelonMod
	{
		public override void OnGUI()
		{
			if (this.showconsole)
			{
				GUI.Box(new Rect(10f, 10f, 200f, 720f), "<color=red>Admin Console</color>");
				GUI.color = Color.white;
				if (this.entidadesur)
				{
					if (GUI.Button(new Rect(10f, 30f, 200f, 20f), "Newborn"))
					{
						PhotonNetwork.NOOU("SUR/NewBorn_Bot", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 50f, 200f, 20f), "Runner"))
					{
						PhotonNetwork.NOOU("SUR/NewBorn_Runner_Bot", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 70f, 200f, 20f), "Crawler Droid"))
					{
						PhotonNetwork.NOOU("SUR/Crawler_Droid_Bot", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 90f, 200f, 20f), "Ranged"))
					{
						PhotonNetwork.NOOU("SUR/NewBorn_Ranged_Bot", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 110f, 200f, 20f), "Boss Runner"))
					{
						PhotonNetwork.NOOU("SUR/BossRunner", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 130f, 200f, 20f), "Tall"))
					{
						PhotonNetwork.NOOU("SUR/NewBorn_Tall_Bot", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 150f, 200f, 20f), "Boss Security"))
					{
						PhotonNetwork.NOOU("SUR/BossSecurity", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 170f, 200f, 20f), "Security"))
					{
						PhotonNetwork.NOOU("SUR/Security_Bot", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 190f, 200f, 20f), "Boss Berserker"))
					{
						PhotonNetwork.NOOU("SUR/BossBeserker", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 210f, 200f, 20f), "Berserker"))
					{
						PhotonNetwork.NOOU("SUR/NewBorn_Beserker_Bot", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 230f, 200f, 20f), "Tinky Winky"))
					{
						PhotonNetwork.NOOU("SUR/BossTinky", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 250f, 200f, 20f), "Tinky Tank"))
					{
						PhotonNetwork.NOOU("SUR/BossTank", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 270f, 200f, 20f), "Shadow"))
					{
						PhotonNetwork.NOOU("SUR/BossShadow", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 290f, 200f, 20f), "Orange Tubby"))
					{
						PhotonNetwork.NOOU("SUR/BossOrangeTubby", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 310f, 200f, 20f), "Yeti"))
					{
						PhotonNetwork.NOOU("SUR/BossMountains", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 330f, 200f, 20f), "Laa Laa"))
					{
						PhotonNetwork.NOOU("SUR/BossLaaLaa", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 350f, 200f, 20f), "Scythe Tubby"))
					{
						PhotonNetwork.NOOU("SUR/BossScytheTubby", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 370f, 200f, 20f), "Headless Dipsy"))
					{
						PhotonNetwork.NOOU("SUR/BossHeadlessDipsy", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 390f, 200f, 20f), "Ghost Girl"))
					{
						PhotonNetwork.NOOU("SUR/BossGhostGirl", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 410f, 200f, 20f), "Dipsy"))
					{
						PhotonNetwork.NOOU("SUR/BossDipsy", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 430f, 200f, 20f), "Cave"))
					{
						PhotonNetwork.NOOU("SUR/BossCave", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 450f, 200f, 20f), "Brute"))
					{
						PhotonNetwork.NOOU("SUR/BossBrute", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 470f, 200f, 20f), "Announcer"))
					{
						PhotonNetwork.NOOU("SUR/BossAnnouncer", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 490f, 200f, 20f), "Imposter"))
					{
						PhotonNetwork.NOOU("SUR/BossImposter", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 510f, 200f, 20f), "White Tubby"))
					{
						PhotonNetwork.NOOU("SUR/BossWhiteTubby", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 530f, 200f, 20f), "Crawler"))
					{
						PhotonNetwork.NOOU("SUR/BossCrawler", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 550f, 200f, 20f), "Po"))
					{
						PhotonNetwork.NOOU("SUR/BossPoPhase1", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 570f, 200f, 20f), "Worker"))
					{
						PhotonNetwork.NOOU("SUR/Worker_Bot", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 590f, 200f, 20f), "Soldier Ranged"))
					{
						PhotonNetwork.NOOU("SUR/Soldier_Ranged_Bot", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 610f, 200f, 20f), "Ron"))
					{
						PhotonNetwork.NOOU("SUR/BossRon", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
					}
					if (GUI.Button(new Rect(10f, 710f, 200f, 20f), "Back"))
					{
						this.entidadesur = false;
					}
				}
				if (!this.entidadesur)
				{
					if (this.entidadescoop)
					{
						if (GUI.Button(new Rect(10f, 30f, 200f, 20f), "Newborn"))
						{
							PhotonNetwork.NOOU("COOP/Newborn", this.PT.position + this.PT.forward * 4f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 50f, 200f, 20f), "Tinky Winky Classic"))
						{
							PhotonNetwork.NOOU("COOP/TinkyWinkyOld", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 70f, 200f, 20f), "Headless Dipsy"))
						{
							PhotonNetwork.NOOU("COOP/HeadlessDipsy", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 90f, 200f, 20f), "Orange Tubby"))
						{
							PhotonNetwork.NOOU("COOP/OrangeTubby", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 110f, 200f, 20f), "Tinky Winky"))
						{
							PhotonNetwork.NOOU("COOP/TinkyWinky", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 130f, 200f, 20f), "Announcer"))
						{
							PhotonNetwork.NOOU("COOP/Announcer", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 150f, 200f, 20f), "Tinky Tank"))
						{
							PhotonNetwork.NOOU("COOP/TinkyTank", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 170f, 200f, 20f), "Shadow Tubby"))
						{
							PhotonNetwork.NOOU("COOP/ShadowTubby", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 190f, 200f, 20f), "Po Spider"))
						{
							PhotonNetwork.NOOU("COOP/PoMutated", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 210f, 200f, 20f), "Mountain Tubby"))
						{
							PhotonNetwork.NOOU("COOP/MountainTubby", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 230f, 200f, 20f), "Dipsy"))
						{
							PhotonNetwork.NOOU("COOP/Dipsy", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 250f, 200f, 20f), "Po"))
						{
							PhotonNetwork.NOOU("COOP/PoPhase1", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 270f, 200f, 20f), "Laa Laa"))
						{
							PhotonNetwork.NOOU("COOP/LaaLaa", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 290f, 200f, 20f), "Po Roach"))
						{
							PhotonNetwork.NOOU("COOP/Po", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 310f, 200f, 20f), "Scythe Tubby"))
						{
							PhotonNetwork.NOOU("COOP/ScytheTubby", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 330f, 200f, 20f), "Brute Tubby"))
						{
							PhotonNetwork.NOOU("COOP/BruteTubby", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 350f, 200f, 20f), "Ghost Girl"))
						{
							PhotonNetwork.NOOU("COOP/GhostGirl", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 370f, 200f, 20f), "Imposter"))
						{
							PhotonNetwork.NOOU("COOP/Imposter", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 390f, 200f, 20f), "Crawler"))
						{
							PhotonNetwork.NOOU("COOP/Crawler", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 410f, 200f, 20f), "White Tubby"))
						{
							PhotonNetwork.NOOU("COOP/WhiteTubby", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 430f, 200f, 20f), "Cave Tubby"))
						{
							PhotonNetwork.NOOU("COOP/CaveTubby", this.PT.position + this.PT.forward * 3f, new Quaternion(0f, 0f, 0f, 0f), 0, null);
						}
						if (GUI.Button(new Rect(10f, 710f, 200f, 20f), "Back"))
						{
							this.entidadescoop = false;
						}
					}
					if (!this.entidadescoop)
					{
						if (this.entidades)
						{
							if (GUI.Button(new Rect(10f, 30f, 200f, 20f), "No Fog"))
							{
								RenderSettings.fog = !RenderSettings.fog;
							}
							if (GUI.Button(new Rect(10f, 70f, 200f, 20f), "Blue Fog"))
							{
								RenderSettings.fogColor = Color.blue;
							}
							if (GUI.Button(new Rect(10f, 90f, 200f, 20f), "Red Fog"))
							{
								RenderSettings.fogColor = Color.red;
							}
							if (GUI.Button(new Rect(10f, 110f, 200f, 20f), "Yellow Fog"))
							{
								RenderSettings.fogColor = Color.yellow;
							}
							if (GUI.Button(new Rect(10f, 130f, 200f, 20f), "Magenta Fog"))
							{
								RenderSettings.fogColor = Color.magenta;
							}
							if (GUI.Button(new Rect(10f, 150f, 200f, 20f), "Black Fog"))
							{
								RenderSettings.fogColor = Color.black;
							}
							if (GUI.Button(new Rect(10f, 170f, 200f, 20f), "White Fog"))
							{
								RenderSettings.fogColor = Color.white;
							}
							if (GUI.Button(new Rect(10f, 190f, 200f, 20f), "Grey Fog"))
							{
								RenderSettings.fogColor = Color.grey;
							}
							if (GUI.Button(new Rect(10f, 210f, 200f, 20f), "Green Fog"))
							{
								RenderSettings.fogColor = Color.green;
							}
							if (GUI.Button(new Rect(10f, 230f, 200f, 20f), "Cyan Fog"))
							{
								RenderSettings.fogColor = Color.cyan;
							}
							if (GUI.Button(new Rect(10f, 710f, 200f, 20f), "Back"))
							{
								this.entidades = false;
							}
						}
						if (!this.entidades)
						{
							if (this.spawnlist)
							{
								if (GUI.Button(new Rect(10f, 30f, 200f, 40f), "Survival Mobs"))
								{
									this.entidadesur = true;
								}
								if (GUI.Button(new Rect(10f, 100f, 200f, 40f), "Collect Mobs"))
								{
									this.entidadescoop = true;
								}
								if (GUI.Button(new Rect(10f, 710f, 200f, 20f), "Back"))
								{
									this.spawnlist = false;
								}
							}
							if (!this.spawnlist && (!this.entidadesur && !this.entidadescoop && !this.entidades && !this.spawnlist && !this.fogmenu))
							{
								if (GUI.Button(new Rect(10f, 130f, 200f, 40f), "Spawns "))
								{
									this.spawnlist = true;
								}
								if (GUI.Button(new Rect(10f, 170f, 200f, 40f), "Fogs"))
								{
									this.entidades = true;
								}
								if (GUI.Button(new Rect(10f, 250f, 200f, 20f), "Weapons"))
								{
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("Chainsaw").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("MK16").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("RPG").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("M249-Saw").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("AKM").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("M40A3").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("Katana").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("MP5N").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("MCS870").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("44 Combat").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("VZ61").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("Shorty").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("Fireaxe").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("Machete").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("XIX II").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("Knife").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("XIX").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("Camera").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("Flashlight").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("FlashlightClassic").GetComponent<WeaponScript>());
									UnityEngine.Object.FindObjectOfType<WeaponManager>().DHFOMKJHLBM.Add(UnityEngine.Object.FindObjectOfType<WeaponManager>().transform.Find("Torch").GetComponent<WeaponScript>());
								}
								if (GUI.Button(new Rect(10f, 170f, 200f, 40f), "Godmode"))
								{
									if (PhotonNetwork.inRoom && UnityEngine.Object.FindObjectOfType<WeaponScript>())
                                    {
										GameObject.FindObjectOfType<WeaponScript>().transform.root.gameObject.GetComponent<PlayerDamage>().PIIDNIGPCDK = float.NaN;
									}
								}
							}
						}
					}
				}
			}
		}

		private Bot[] bots
		{
			get
			{
				return UnityEngine.Object.FindObjectsOfType<Bot>();
			}
		}

		private BossBot[] bossBots
		{
			get
			{
				return UnityEngine.Object.FindObjectsOfType<BossBot>();
			}
		}

		private void Awake()
		{
		}

		public override void OnUpdate()
		{
			if (Input.GetKeyDown(KeyCode.F1))
			{
				this.showconsole = !this.showconsole;
			}
			if (this.antifog && Input.GetKey(KeyCode.B))
			{
				RenderSettings.fog = !RenderSettings.fog;
			}
		}

		private Transform PT
		{
			get
			{
				return UnityEngine.Object.FindObjectOfType<WeaponScript>().transform.root.gameObject.transform;
			}
		}

		public bool showconsole;

		public bool freezenpc;

		public bool spawnlist;

		public bool entidadesur;

		public bool weaponsMenu;

		public bool entidadescoop;

		public bool entidades;

		public bool fogmenu;

		public MainMenu mainMenu;

		public LobbyMenu lobbyMenu;

		public bool antifog;
	}
}
