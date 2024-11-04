<div class="problems_problem_content__Xm_eO"><p><span style="font-size: 18.6667px;">Implement Quick Sort, a Divide and Conquer algorithm, to sort an array, <strong>arr</strong>[] in ascending order. Given an array, <strong>arr</strong>[], with starting index <strong>low</strong> and ending index <strong>high</strong>, complete the functions <strong>partition()</strong> and <strong>quickSort()</strong>. Use the last element as the pivot so that all elements less than or equal to the pivot come before it, and elements greater than the pivot follow it.</span></p>
<p><span style="font-size: 14pt;"><strong>Note</strong>: The <strong>low</strong> and <strong>high</strong> are inclusive.</span></p>
<p><span style="font-size: 14pt;"><strong>Examples:</strong></span></p>
<pre><span style="font-size: 14pt;"><strong>Input: </strong>arr[] = [4, 1, 3, 9, 7]
<strong>Output: </strong>[1, 3, 4, 7, 9]<br><strong>Explanation:</strong> After sorting, all elements are arranged in ascending order.</span></pre>
<pre><span style="font-size: 14pt;"><strong>Input: </strong>arr[] = [2, 1, 6, 10, 4, 1, 3, 9, 7]
<strong>Output: [</strong>1, 1, 2, 3, 4, 6, 7, 9, 10]<br><strong>Explanation:</strong> Duplicate elements (1) are retained in sorted order.</span></pre>
<pre><span style="font-size: 14pt;"><strong>Input: </strong>arr[] = [5, 5, 5, 5]
<strong>Output: </strong>[5, 5, 5, 5]<br><strong>Explanation:</strong> All elements are identical, so the array remains unchanged.</span></pre>
<p><span style="font-size: 14pt;"><strong>Constraints:</strong><br>1 &lt;= arr.size() &lt;= 10<sup>3</sup><br>1 &lt;= arr[i] &lt;= 10<sup>4</sup></span></p></div>
