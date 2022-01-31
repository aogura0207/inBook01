using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

/// <summary>
/// ArrangeText to fit sentences to pages
/// �w�肵���������ŕ��������؂�
/// </summary>
public static class StringExtentions
{
    #region Extract Title
    public static string ExtractTargetPattern(this string self, string regexPattern)
    {
        // ���K�\���p�^�[���ɍ���������E�o
        // <head>.*</head> �� <body>.*</body>�@�̓��
        string textWithHTML = Regex.Match(self, regexPattern, RegexOptions.Singleline).Value;

        // html�^�O�폜
        string titleOrContent = Regex.Replace(textWithHTML, "<[^>]*?>", string.Empty);

        string trimedTitleOrContent = titleOrContent.Trim();

        Debug.Log(trimedTitleOrContent);
        return trimedTitleOrContent;
    }
    #endregion


    #region Cut Text by the number of characters in a page
    public static List<string> CutText(this string self, int charactersInPage, int pageCount)
    {
        var result = new List<string>();

        for (int i = 0; i < pageCount; i++)
        {
            int start = charactersInPage * i;

            if (self.Length <= start)
            {
                break;
            }
            if (self.Length < start + charactersInPage)
            {
                result.Add(self.Substring(start));
            }
            else
            {
                result.Add(self.Substring(start, charactersInPage));
            }
        }
        return result;
    }
    #endregion
}
