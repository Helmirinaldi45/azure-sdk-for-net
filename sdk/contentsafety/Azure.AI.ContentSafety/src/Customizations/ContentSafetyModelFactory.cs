// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.Core;
using System.Linq;

namespace Azure.AI.ContentSafety
{
    /// <summary> ContentSafety model factory. </summary>
    [CodeGenModel("AIContentSafetyModelFactory")]
    public static partial class ContentSafetyModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ContentSafety.AnalyzeTextOptions"/>. </summary>
        /// <param name="text"> The text needs to be analyzed. We support a maximum of 10k Unicode characters (Unicode code points) in the text of one request. </param>
        /// <param name="categories"> The categories will be analyzed. If they are not assigned, a default set of analysis results for the categories will be returned. </param>
        /// <param name="blocklistNames"> The names of blocklists. </param>
        /// <param name="haltOnBlocklistHit"> When set to true, further analyses of harmful content will not be performed in cases where blocklists are hit. When set to false, all analyses of harmful content will be performed, whether or not blocklists are hit. </param>
        /// <param name="outputType"> This refers to the type of text analysis output. If no value is assigned, the default value will be "FourSeverityLevels". </param>
        /// <returns> A new <see cref="ContentSafety.AnalyzeTextOptions"/> instance for mocking. </returns>
        public static AnalyzeTextOptions AnalyzeTextOptions(string text = null, IEnumerable<TextCategory> categories = null, IEnumerable<string> blocklistNames = null, bool? haltOnBlocklistHit = null, AnalyzeTextOutputType? outputType = null)
        {
            categories ??= new List<TextCategory>();
            blocklistNames ??= new List<string>();

            return new AnalyzeTextOptions(
                text,
                categories?.ToList(),
                blocklistNames?.ToList(),
                haltOnBlocklistHit,
                outputType,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ContentSafety.AnalyzeTextResult"/>. </summary>
        /// <param name="blocklistsMatch"> The blocklist match details. </param>
        /// <param name="categoriesAnalysis"> Analysis result for categories. </param>
        /// <returns> A new <see cref="ContentSafety.AnalyzeTextResult"/> instance for mocking. </returns>
        public static AnalyzeTextResult AnalyzeTextResult(IEnumerable<TextBlocklistMatch> blocklistsMatch = null, IEnumerable<TextCategoriesAnalysis> categoriesAnalysis = null)
        {
            blocklistsMatch ??= new List<TextBlocklistMatch>();
            categoriesAnalysis ??= new List<TextCategoriesAnalysis>();

            return new AnalyzeTextResult(blocklistsMatch?.ToList(), categoriesAnalysis?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ContentSafety.TextBlocklistMatch"/>. </summary>
        /// <param name="blocklistName"> The name of the matched blocklist. </param>
        /// <param name="blocklistItemId"> The ID of the matched item. </param>
        /// <param name="blocklistItemText"> The content of the matched item. </param>
        /// <returns> A new <see cref="ContentSafety.TextBlocklistMatch"/> instance for mocking. </returns>
        public static TextBlocklistMatch TextBlocklistMatch(string blocklistName = null, string blocklistItemId = null, string blocklistItemText = null)
        {
            return new TextBlocklistMatch(blocklistName, blocklistItemId, blocklistItemText, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ContentSafety.TextCategoriesAnalysis"/>. </summary>
        /// <param name="category"> The text analysis category. </param>
        /// <param name="severity"> The value increases with the severity of the input content. The value of this field is determined by the output type specified in the request. The output type could be ‘FourSeverityLevels’ or ‘EightSeverity Levels’, and the output value can be 0, 2, 4, 6 or 0, 1, 2, 3, 4, 5, 6, or 7. </param>
        /// <returns> A new <see cref="ContentSafety.TextCategoriesAnalysis"/> instance for mocking. </returns>
        public static TextCategoriesAnalysis TextCategoriesAnalysis(TextCategory category = default, int? severity = null)
        {
            return new TextCategoriesAnalysis(category, severity, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ContentSafety.AnalyzeImageOptions"/>. </summary>
        /// <param name="image"> The image needs to be analyzed. </param>
        /// <param name="categories"> The categories will be analyzed. If they are not assigned, a default set of analysis results for the categories will be returned. </param>
        /// <param name="outputType"> This refers to the type of image analysis output. If no value is assigned, the default value will be "FourSeverityLevels". </param>
        /// <returns> A new <see cref="ContentSafety.AnalyzeImageOptions"/> instance for mocking. </returns>
        public static AnalyzeImageOptions AnalyzeImageOptions(ContentSafetyImageData image = null, IEnumerable<ImageCategory> categories = null, AnalyzeImageOutputType? outputType = null)
        {
            categories ??= new List<ImageCategory>();

            return new AnalyzeImageOptions(image, categories?.ToList(), outputType, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ContentSafety.AnalyzeImageResult"/>. </summary>
        /// <param name="categoriesAnalysis"> Analysis result for categories. </param>
        /// <returns> A new <see cref="ContentSafety.AnalyzeImageResult"/> instance for mocking. </returns>
        public static AnalyzeImageResult AnalyzeImageResult(IEnumerable<ImageCategoriesAnalysis> categoriesAnalysis = null)
        {
            categoriesAnalysis ??= new List<ImageCategoriesAnalysis>();

            return new AnalyzeImageResult(categoriesAnalysis?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ContentSafety.ImageCategoriesAnalysis"/>. </summary>
        /// <param name="category"> The image analysis category. </param>
        /// <param name="severity"> The value increases with the severity of the input content. The value of this field is determined by the output type specified in the request. The output type could be ‘FourSeverityLevels’, and the output value can be 0, 2, 4, 6. </param>
        /// <returns> A new <see cref="ContentSafety.ImageCategoriesAnalysis"/> instance for mocking. </returns>
        public static ImageCategoriesAnalysis ImageCategoriesAnalysis(ImageCategory category = default, int? severity = null)
        {
            return new ImageCategoriesAnalysis(category, severity, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ContentSafety.TextBlocklistItem"/>. </summary>
        /// <param name="blocklistItemId"> The service will generate a BlocklistItemId, which will be a UUID. </param>
        /// <param name="description"> BlocklistItem description. </param>
        /// <param name="text"> BlocklistItem content. </param>
        /// <returns> A new <see cref="ContentSafety.TextBlocklistItem"/> instance for mocking. </returns>
        public static TextBlocklistItem TextBlocklistItem(string blocklistItemId = null, string description = null, string text = null)
        {
            return new TextBlocklistItem(blocklistItemId, description, text, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ContentSafety.AddOrUpdateTextBlocklistItemsResult"/>. </summary>
        /// <param name="blocklistItems"> Array of blocklistItems have been added. </param>
        /// <returns> A new <see cref="ContentSafety.AddOrUpdateTextBlocklistItemsResult"/> instance for mocking. </returns>
        public static AddOrUpdateTextBlocklistItemsResult AddOrUpdateTextBlocklistItemsResult(IEnumerable<TextBlocklistItem> blocklistItems = null)
        {
            blocklistItems ??= new List<TextBlocklistItem>();

            return new AddOrUpdateTextBlocklistItemsResult(blocklistItems?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ContentSafety.TextBlocklist"/>. </summary>
        /// <param name="name"> Text blocklist name. </param>
        /// <param name="description"> Text blocklist description. </param>
        /// <returns> A new <see cref="ContentSafety.TextBlocklist"/> instance for mocking. </returns>
        public static TextBlocklist TextBlocklist(string name = null, string description = null)
        {
            return new TextBlocklist(name, description, serializedAdditionalRawData: null);
        }
    }
}
