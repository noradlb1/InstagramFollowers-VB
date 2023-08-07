Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Threading.Tasks
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Interactions
Imports OpenQA.Selenium.Remote
Imports OpenQA.Selenium.Support.UI
Imports System.Runtime.CompilerServices

Namespace InstagramFollowers
    Class Selenium
        Public Property User As String
        Public Property Pass As String
        Public Property [Friend] As String
        Public Property Time As Integer
        Public Property FollowOrFollowing As Boolean
        Public Property FollowOrUnfollow As Boolean

        Public Sub RunScript()
            Dim options As OpenQA.Selenium.Chrome.ChromeOptions = New ChromeOptions()
            options.AddArgument("--incognito")
            Dim driver As IWebDriver = New ChromeDriver(options)
            Dim url As String = "https://www.instagram.com/", login As String = "//*[@id='loginForm']/div/div[1]/div/label/input", password As String = "//*[@id='loginForm']/div/div[2]/div/label/input", user As String = user, pass As String = pass, enterUser As String = "//*[@id='loginForm']/div/div[3]/button/div", searchBar As String = "//*[@id='react-root']/section/nav/div[2]/div/div/div[2]/div", [friend] As String = [friend], searchBarSendKeys As String = "//*[@id='react-root']/section/nav/div[2]/div/div/div[2]/input", enterFoundFriend As String = "//*[@id='react-root']/section/nav/div[2]/div/div/div[2]/div[3]/div[2]/div/a[1]", numberOfFollowers As String = "//*[@id='react-root']/section/main/div/header/section/ul/li[2]/a/span"
            Dim followOrFollowers As Boolean = FollowOrFollowing
            Dim unfollow As Boolean = FollowOrUnfollow
            Dim time As Integer = time
            driver.Navigate().GoToUrl(url)
            Dim actions As Actions = New Actions(driver)

            Try
                driver.FindElement(By.XPath(login), 10).SendKeys(user)
                driver.FindElement(By.XPath(password)).SendKeys(pass)
                driver.FindElement(By.XPath(enterUser)).Click()

                If unfollow Then
                    driver.FindElement(By.XPath(searchBar), 10).Click()
                    driver.FindElement(By.XPath(searchBarSendKeys)).SendKeys([friend])
                    driver.FindElement(By.XPath(enterFoundFriend), 10).Click()

                    If Not followOrFollowers Then
                        Dim numOfFollowers = driver.FindElement(By.XPath(numberOfFollowers), 10)
                        Dim numberOfFolStr As String = numOfFollowers.GetAttribute("title")
                        Dim numberOfFollowersInt As Integer = toInt(numberOfFolStr)
                        numOfFollowers.Click()
                        Dim pathToFollowFirst As String = "/html/body/div[4]/div/div/div[2]/ul/div/li["
                        Dim pathToFollowSecond As String = "]/div/div[3]"
                        Dim followFollower As IWebElement = Nothing
                        Dim list As IWebElement = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]"), 10)
                        Dim pathToFollow As String = ""
                        Dim random As Random = New Random()

                        For i As Integer = 1 To numberOfFollowersInt + 1 - 1

                            Try
                                pathToFollow = pathToFollowFirst & i.ToString() & pathToFollowSecond
                                followFollower = driver.FindElement(By.XPath(pathToFollow))
                            Catch __unusedException1__ As Exception
                                pathToFollow = pathToFollowFirst & i.ToString() & "]/div/div[2]"
                                followFollower = driver.FindElement(By.XPath(pathToFollow), 1)
                            End Try

                            Dim js As IJavaScriptExecutor = CType(driver, IJavaScriptExecutor)
                            js.ExecuteScript("arguments[0].scrollIntoView(false);", followFollower)
                            Dim followingOrNot As String = followFollower.Text

                            If followingOrNot = "Follow" Then
                                followFollower.Click()
                                Console.WriteLine(followingOrNot)
                            End If

                            Sleep(random.[Next](1, time))
                        Next
                    End If
                Else
                End If

            Catch e As Exception
                Debug.WriteLine(e)
            End Try
        End Sub

        Public Function GetRandomNumberInRange(ByVal random As Random, ByVal minNumber As Double, ByVal maxNumber As Double) As Double
            Return random.NextDouble() * (maxNumber - minNumber) + minNumber
        End Function

        Public Sub ScrollTo(ByVal element As IWebElement, ByVal driver As IWebDriver, ByVal Optional xPosition As Integer = 0, ByVal Optional yPosition As Integer = 0)
            Dim js As IJavaScriptExecutor = CType(driver, IJavaScriptExecutor)
            js.ExecuteScript(String.Format("{0}.scrollTo({1}, {2})", element, xPosition, yPosition))
        End Sub

        Public Function ScrollToView(ByVal driver As IWebDriver, ByVal selector As By) As IWebElement
            Dim element = driver.FindElement(selector, 10)
            ScrollToView(driver, element)
            Return element
        End Function

        Public Sub ScrollToView(ByVal driver As IWebDriver, ByVal element As IWebElement)
            If element.Location.Y > 200 Then
                ScrollTo(element, driver, 0, element.Location.Y - 100)
            End If
        End Sub

        Private Sub Sleep(ByVal time As Integer)
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(time))
        End Sub

        Private Function toInt(ByVal x As String) As Integer
            Dim sb As StringBuilder = New StringBuilder()

            For i As Integer = 0 To x.Length - 1
                Dim c As Char = x(i)

                If c <> ","c Then
                    sb.Append(c)
                End If
            Next

            Return Convert.ToInt32(sb.ToString())
        End Function
    End Class

    Module WebDriverExtensions
        <Extension()>
        Function FindElement(ByVal driver As IWebDriver, ByVal by As By, ByVal timeoutInSeconds As Integer) As IWebElement
            If timeoutInSeconds > 0 Then
                Dim wait = New WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds))
                Return wait.Until(Function(drv) drv.FindElement(by))
            End If

            Return driver.FindElement(by)
        End Function
    End Module
End Namespace
