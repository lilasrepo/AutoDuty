# AutoDuty（繁中移植版 · TC12） / Traditional-Chinese Port

> 自動幫你跑副本。<br>
> Runs dungeons for you.

**繁體中文**：這是 **[AutoDuty](https://github.com/erdelf/AutoDuty)** 的繁體中文客戶端移植版，對應 **FFXIV 7.1 / yanmucorp Dalamud API12（.NET 9）**。本專案僅做相容性移植，**非官方、非原作維護**；所有原始功能與設計著作權歸原作者 **Herculezz、erdelf**。

**English**: A Traditional-Chinese-client port of **[AutoDuty](https://github.com/erdelf/AutoDuty)** targeting **FFXIV 7.1 / yanmucorp Dalamud API12 (.NET 9)**. Compatibility port only — **unofficial and not maintained by the original author**. All original work © **Herculezz, erdelf**.

---

## 這是什麼 / About

自動帶你跑副本，支援盟友作戰（Trust）、隨從支援（Duty Support）、小隊（Squadron）、異聞副本（Variant）與一般副本，會自動尋路、戰鬥、推王。

Automatically runs duties for you — Trust, Duty Support, Squadrons, Variants and regular dungeons — handling navigation, combat and bosses.

## 需要的前置插件 / Required plugins

本插件需要以下插件才能運作（本插件庫皆提供 TC12 版）：<br>
This plugin requires the following (all available as TC12 builds in this repo):

- **Boss Mod (TC12)** — 戰鬥處理 / combat
- **vnavmesh (TC12)** — 自動尋路 / navigation
- 一個循環插件（擇一）/ a rotation plugin (one of): **Wrath Combo (TC12)**、BossMod AutoRotation、RotationSolverReborn

## 安裝 / Installation

**繁體中文**
1. 使用 **XIVTCLauncher** 啟動繁體中文客戶端。
2. 遊戲內輸入 `/xlsettings` → 切到 **Experimental** 分頁 → **Custom Plugin Repositories（自訂插件庫）**。
3. 貼上下列網址並按 **+** 儲存：
   ```
   https://raw.githubusercontent.com/lilasrepo/DalamudPlugins/main/pluginmaster.json
   ```
4. 輸入 `/xlplugins`，搜尋 **AutoDuty (TC12)** → 安裝 → 啟用。

**English**
1. Launch the Traditional-Chinese client with **XIVTCLauncher**.
2. In-game, type `/xlsettings` → **Experimental** tab → **Custom Plugin Repositories**.
3. Add this URL and save with **+**:
   ```
   https://raw.githubusercontent.com/lilasrepo/DalamudPlugins/main/pluginmaster.json
   ```
4. Type `/xlplugins`, search **AutoDuty (TC12)** → Install → Enable.

## 對應版本 / Compatibility

| 項目 / Item | 版本 / Version |
|---|---|
| 遊戲 / Game | FFXIV 7.1（繁中客戶端 / TC client） |
| Dalamud | yanmucorp API12（.NET 9） |
| 移植自上游 / Ported from upstream | v0.0.0.311 |

## 原作與授權 / Credits & License

本專案 fork 自 **[erdelf/AutoDuty](https://github.com/erdelf/AutoDuty)**，授權沿用上游；所有原始功能著作權歸 **Herculezz、erdelf**。<br>
Forked from **[erdelf/AutoDuty](https://github.com/erdelf/AutoDuty)**. License follows upstream; all original work © **Herculezz, erdelf**.

## 免責聲明 / Disclaimer

第三方插件，使用風險自負。**移植相關問題請回報到本 repo 的 Issues，請勿打擾上游原作者。**<br>
Third-party plugin — use at your own risk. **For port-specific issues please open an Issue here; do not contact the upstream author.**
