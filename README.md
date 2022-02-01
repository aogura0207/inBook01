# inBook01 : See you in Books!
## 概要 / Overview
* ソロプレイ / Soloplay ([動画リンク / Video Link](https://youtu.be/R1LSrxXduy0))
* マルチプレイ / Multiplay ([動画リンク / Video Link](https://youtu.be/czBtSLcCEbA))

<p align="center">
  <img src="./Assets/ReadmeImages/ForReadme.jpg" width="738">
</p>

## 作品の動機　/ Motivation of This Project

（日本語）

本の中が新しいコミュニティの場になると思った。

inBookを通じて、場所は違えど、同じ時刻に、同じ本を読んでいる人達が、同じ空間に集まることができる。

そこで、何が起こるか想像した。

本の中で知り合い、本の中で感想を伝えあい、本の中で討論しあい、本の中で教えあい、本の中で仲良くなり、本の中で～～～ 

本の中に入れたら、何が起きるだろう？

(English)

The inside of the book would be a new place for communities if we can enter books.

When we use inBook, overcoming the difference of place, we can gather in a same place with others reading the same book at the same time.

What happens there?

In books will we encounter someone, share each thought on the book, discuss the book, teach each other and become friends and ...

What if we can enter books?

## 実装したこと / How It Works
（日本語）
1.	前もって青空文庫で人気な本の情報を500冊スクレイピング。[csv file](https://github.com/aogura0207/inBook01/blob/main/Assets/Resources/CSV/BookURLtest.csv)にまとめる。
2.	Home Sceneのスタート関数で1のExcel fileをもとに本500冊を作成。
3.	2で作成した本から、プレイヤーは本を選び、Unityはプレイヤーが選んだ本のURLを取得
4.	Book Sceneのスタート関数で、選んだ本のURLから本文をUnityWebrequestで取得、それを元にページ作成

Photonを使用し、HomeSceneではロビーを用いたマッチメイキング、BookSceneではボイスチャットをできるようにした。

このプロジェクトは[こちらの講義](https://www.udemy.com/course/multiplayer-virtual-reality-vr-development-with-unity/)を大いに参考とした。

(English)
1. Aside from this unity project, I scraped information about 500 popular Aozora books and save it as [csv file](https://github.com/aogura0207/inBook01/blob/main/Assets/Resources/CSV/BookURLtest.csv).
2. Start function in the "HomeScene" makes 500 books accoding to the 1's csv file.
3. Player chooses his favorite book, and Unity gets the books URL.
4. Start function in the "BookScene" gets book's text, using UnityWebrequest, and instantiates pages.

Using Photon, I implemented Lobby Matchmaking in HomeScene and Voice chat in BookScene.

While driving this project, I learned a lot from [this Lecture.](https://www.udemy.com/course/multiplayer-virtual-reality-vr-development-with-unity/)

## 自分のことについて / About Me

横浜国立大学　建築学科　3年

Unity, C# ともに５か月前にOculus Quest 2を買った際に始めました。

建築学生として空間・環境設計に興味がありますが、最近、VR空間に魅せられています。

物質的な世界、電子的な世界、分け隔てなく、面白い空間、環境を作りたいです！！

-------------------------------------------------------------------------------------------------------------

YNU. Department of Architecture. 3rd year

I started Unity and C# 5 month ago. As an architecture student, I'm interested in designing space or environment, and lately VR space or environment has lured my interest.

I want to design interesting space regardless of whether it's physical or electronic!
