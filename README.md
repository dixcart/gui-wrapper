#GUI Wrapper

A simple wrapper to run GUI apps that accept command line arguments (such as ntbackup) inside another script and retrieve the exit code.

When running GUI apps through a CLI such as powershell, they usually release control back to the CLI immediately and you are unable to monitor when the app has finished executing and what it's exit code was.  This program launches the app for you, waits for it to exit then exits itself with the same error code as the GUI did.

##Usage

    gui-wrapper.exe filename arg1 arg2 <...>
	
If your arguments contain double quotes `"` they will need to be escaped with a `\` and themselves wrapped in quotes, e.g.

    gui-wrapper.exe ntbackup.exe "backup \"c:\backup scripts\whatever\all files.bkf\""
	
##License

<a rel="license" href="http://creativecommons.org/licenses/by-sa/3.0/"><img alt="Creative Commons Licence" style="border-width:0" src="http://i.creativecommons.org/l/by-sa/3.0/88x31.png" /></a><br /><span xmlns:dct="http://purl.org/dc/terms/" href="http://purl.org/dc/dcmitype/InteractiveResource" property="dct:title" rel="dct:type">GUI-Wrapper</span> by <a xmlns:cc="http://creativecommons.org/ns#" href="http://dixcart.com/it" property="cc:attributionName" rel="cc:attributionURL">Dixcart Technical Solutions Limited</a> is licensed under a <a rel="license" href="http://creativecommons.org/licenses/by-sa/3.0/">Creative Commons Attribution-ShareAlike 3.0 Unported License</a>.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.